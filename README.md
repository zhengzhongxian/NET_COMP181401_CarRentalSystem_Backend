# RentiCar - Car Rental System

> A comprehensive .NET 8.0 Car Rental Platform built with Clean Architecture and CQRS.

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Tech Stack](#tech-stack)
- [Domain Model](#domain-model)
- [Feature Modules](#feature-modules)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Docker Compose (Recommended)](#docker-compose-recommended)
  - [Local Development](#local-development)
  - [Database Setup](#database-setup)
- [Configuration](#configuration)
- [API Endpoints](#api-endpoints)
- [External Integrations](#external-integrations)
- [Development Conventions](#development-conventions)
- [Code Quality](#code-quality)
- [Project Structure](#project-structure)

---

## Overview

RentiCar is a full-featured car rental system designed for managing vehicle fleets, bookings, payments, and customer relationships. It supports:

- **Customer-facing**: Vehicle browsing, booking creation, payment processing, eKYC verification, booking management
- **Admin-facing**: Fleet management, dashboard analytics, refund processing, violation tracking, system settings
- **Background**: Read/write database synchronization, real-time notifications, webhook processing

---

## Architecture

The solution follows **Clean Architecture** with **CQRS** (Command Query Responsibility Segregation) and **Event-Driven** patterns:

```
┌─────────────────────────────────────────────────────────┐
│                    API Layer (Presentation)              │
│  Controllers → MediatR ISender → Commands/Queries        │
│  Middlewares (Exception Handling, Rate Limiting)         │
│  AutoMapper Profiles                                     │
└──────────────────────┬──────────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────────┐
│                 Application Layer                        │
│  Features (Auth, Bookings, Vehicles, Payments, ...)      │
│  MediatR Commands/Queries + FluentValidation Pipeline    │
│  MassTransit Events & Consumers                          │
└──────────────────────┬──────────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────────┐
│                  Domain Layer (Core)                      │
│  Entities (33+) | Enums (22) | Exceptions | Interfaces   │
│  BaseEntity<T> | IAuditable | ISoftDelete | IRowVersion  │
└──────────────────────┬──────────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────────┐
│               Infrastructure Layer                       │
│  EF Core (Read/Write DbContext) | Dapper                │
│  Redis | RabbitMQ/MassTransit | MinIO | SignalR         │
│  Elasticsearch + Kibana | Serilog Sink                  │
│  gRPC | JWT Auth | Google OAuth | Quartz Scheduler      │
│  Payment (PayOS, VnPay) | SMS (Twilio) | eKYC (VNPT)    │
│  Cloudinary | Email (SMTP/Gmail API) | AI Services       │
└─────────────────────────────────────────────────────────┘
```

### Key Design Patterns

| Pattern | Implementation |
|---------|---------------|
| **CQRS** | Separate `RenticarWriteDbContext` (commands) and `RenticarReadDbContext` (queries) |
| **MediatR** | All use cases as Commands (`ICommand<T>`) and Queries (`IQuery<T>`) |
| **Repository + Unit of Work** | `IReadRepository<T>`, `IWriteRepository<T>`, `IUnitOfWork` with transaction support |
| **Strategy Pattern** | `ICreateBookingPaymentStrategy` (PayOS/VnPay/NoExternal), `IPaymentCommandStrategy` (Deposit/Final/Violation), `IPaymentEmailStrategy`, `IRefundEmailStrategy` |
| **TaskQueue (Bounded Channel)** | `TaskQueue<TRequest, TResult>` with configurable worker pool to control concurrency for high-traffic endpoints (e.g., CreateBooking) |
| **Distributed Locking** | Redis-based `AcquireLockAsync`/`ReleaseLockAsync` for payment transaction safety and customer operation exclusivity |
| **Soft Deletes** | `ISoftDelete` interface with `IsDeleted`/`DeletedAt`/`DeletedBy` |
| **Auditing** | `IAuditable` with `CreatedAt`/`CreatedBy`/`UpdatedAt`/`UpdatedBy` |
| **Optimistic Concurrency** | `IRowVersion` with `byte[]` row versioning |
| **Event-Driven** | MassTransit events (`BookingCreatedEvent`, etc.) with dedicated consumers |
| **Validation Pipeline** | FluentValidation as MediatR pipeline behavior |
| **Denormalized Reads** | `BookingReadFlat`, `VehicleReadFlat` for query performance |

---

## Tech Stack

| Category | Technology |
|----------|------------|
| **Framework** | .NET 8.0 (ASP.NET Core) |
| **Language** | C# 12, Nullable Reference Types |
| **Database** | SQL Server 2022 (EF Core 8.0 + Dapper) |
| **Caching** | Redis (StackExchange.Redis + NRedisStack) |
| **Messaging** | RabbitMQ + MassTransit |
| **Object Storage** | MinIO |
| **API Docs** | Swagger / OpenAPI |
| **Authentication** | JWT Bearer + Google OAuth |
| **Payment** | PayOS, VnPay |
| **eKYC** | VNPT (CCCD OCR, face liveness, face match) |
| **SMS** | Twilio, SpeedSMS |
| **Email** | SMTP, Gmail API (OAuth2) |
| **Image CDN** | Cloudinary |
| **AI/ML** | Semantic Kernel, ONNX Runtime, gRPC AI services |
| **PDF** | QuestPDF (contract generation) |
| **Scheduling** | Quartz.NET |
| **Real-time** | SignalR (`/hubs/notification`) |
| **Search & Analytics** | Elasticsearch 8.13 + Kibana 8.13 |
| **Logging** | Serilog (console + rolling files + Elasticsearch sink) |
| **Validation** | FluentValidation |
| **Mapping** | AutoMapper |
| **Containerization** | Docker + Docker Compose |

---

## Domain Model

### Entities (33+)

**User & Identity:**
`User`, `Customer`, `Role`, `UserRole`, `UserClaim`, `UserLogin`, `UserToken`, `UserSession`, `RoleClaim`, `UserVerification`

**Vehicles:**
`Vehicle`, `VehicleModel`, `VehicleCategory`, `VehicleImage`, `VehicleAttribute`, `VehicleReadFlat`, `VehicleReturnImage`, `Fuel`, `Transmission`

**Bookings:**
`Booking`, `BookingImage`, `BookingInsurance`, `BookingViolation`, `BookingReadFlat`

**Payments & Refunds:**
`PaymentTransaction`, `TransactionProcessingLog`, `RefundRequest`, `RefundProcessingLog`

**System:**
`Location`, `InsurancePackage`, `SystemSetting`, `TermsAndConditions`, `WebhookLog`

### Key Enums (22)

`BookingStatus` (9 states), `VehicleStatus` (4 states), `UserStatus` (6 states), `PaymentMethod` (InCash/PayOS/VnPay), `TransactionType` (6 types), `TransactionStatus` (6 states), `RefundStatus` (8 states), `ViolationType` (Fuel/Late/Damage), `VerificationStatus`, `LicenseClass` (A1–E), `RoleAccessibility`, `LoginProvider`, `TermsType`, `WebhookEventType`, and more.

---

## Feature Modules

| Module | Commands | Queries | Description |
|--------|----------|---------|-------------|
| **Auth** | 15 | 3 | Login, logout, Google auth, OTP, password reset, phone verification, session management |
| **Bookings** | 11 | 6 | Create/cancel/complete bookings, final payment, contract generation, vehicle swap, QR return |
| **Vehicles** | 15 | 4 | CRUD, images, attributes, models inventory, availability, promotions, Redis sync |
| **Dashboard** | – | 12 | Revenue stats, top rented vehicles, daily revenue, user stats, branch comparison |
| **Users** | 8 | 3 | Profile, avatar, phone, status, admin profile, role/claim management |
| **Roles** | 7 | 2 | Role CRUD, role claims, accessibility management |
| **Payments** | 4 | 1 | Deposit/final/violation payment processing, payment method listing |
| **RefundRequests** | 2 | 1 | Approve/reject refunds, view pending requests |
| **Locations** | 4 | 2 | Branch CRUD, thumbnail management, paged listing |
| **Fuels** | 3 | 1 | Fuel type CRUD |
| **Transmissions** | 3 | 2 | Transmission type CRUD |
| **VehicleCategories** | 3 | 2 | Category CRUD |
| **Insurances** | – | 1 | Active insurance packages |
| **Terms** | – | 1 | Active booking terms & conditions |
| **SystemSettings** | 1 | 2 | Update settings, public/private settings retrieval |
| **Ekyc** | 2 | – | CCCD identity verification, driver license verification (VNPT) |
| **Violations** | 2 | – | Create violation payments, resolve violations |
| **Webhooks** | – | – | Async PayOS webhook processing via RabbitMQ consumers |
| **Permissions** | – | 1 | Get available permissions |

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [SQL Server 2022](https://www.microsoft.com/sql-server/sql-server-downloads) (optional if using Docker)

### Docker Compose (Recommended)

Start all services (SQL Server, Redis, RabbitMQ, MinIO, API, Sync Tool) with a single command:

```bash
docker-compose up -d
```

**Default Ports:**

| Service | Port | URL |
|---------|------|-----|
| API | 1610 | http://localhost:1610 |
| Swagger UI | 1610 | http://localhost:1610/swagger |
| SQL Server | 1433 | `localhost,1433` |
| Redis | 6379 | `localhost:6379` |
| Redis Insight | 8001 | http://localhost:8001 |
| RabbitMQ Management | 15672 | http://localhost:15672 (guest/guest) |
| MinIO Console | 9001 | http://localhost:9001 (vagabond/blacksun) |
| MinIO API | 9000 | http://localhost:9000 |
| Elasticsearch | 9200 | http://localhost:9200 |
| Kibana | 5601 | http://localhost:5601 |

Stop all services:

```bash
docker-compose down
```

### Local Development

```bash
# Restore NuGet packages
dotnet restore

# Build all projects
dotnet build

# Run the API (Development environment)
dotnet run --project NET_CarRentalSystem/NET_CarRentalSystem.API.csproj

# Run the sync tool (separate terminal)
dotnet run --project NET_CarRentalSystem.SyncDataTool/NET_CarRentalSystem.SyncDataTool.csproj
```

### Database Setup

The API automatically applies EF Core migrations on startup. To seed initial data:

```bash
# Seed the write database
sqlcmd -S localhost,1433 -U sa -P 'Password123!' -d Renticar_WriteDB -i Scripts/seed_writedb_comprehensive.sql

# Seed the read database
sqlcmd -S localhost,1433 -U sa -P 'Password123!' -d Renticar_ReadDB -i Scripts/seed_readdb_comprehensive.sql
```

**Note:** SQL Server requires `Encrypt=True;TrustServerCertificate=True;` in the connection string (configured in `appsettings.json`).

---

## Configuration

### appsettings.json

```json
{
  "ConnectionStrings": {
    "RenticarWriteDbContext": "Data Source=sqlserver,1433;Database=Renticar_WriteDB;...",
    "RenticarReadDbContext": "Data Source=sqlserver,1433;Database=Renticar_ReadDB;...",
    "Redis": "redis:6379"
  },
  "SyncDataToolSettings": {
    "SyncIntervalInSeconds": 2,
    "DbRetryDelayInSeconds": 5,
    "TablesToSync": [ ... ]
  }
}
```

### Sensitive Configuration

Use .NET User Secrets for development:

```bash
cd NET_CarRentalSystem
dotnet user-secrets set "JwtSettings:SecretKey" "your-secret-key"
dotnet user-secrets set "MinioSettings:AccessKey" "your-access-key"
dotnet user-secrets set "PayOsSettings:ClientId" "your-client-id"
```

### Logging

Serilog is configured with:
- **Console** output
- **Rolling file** output (`Logs/log-{date}.txt`), daily rotation, 7-day retention
- **Elasticsearch** sink – structured logs indexed for Kibana dashboards and search

---

## API Endpoints

### Controllers (20)

| Controller | Base Route | Auth | Description |
|------------|-----------|------|-------------|
| `AuthController` | `/api/auth` | Mostly anonymous | Login, register, Google auth, OTP, sessions |
| `BookingsController` | `/api/bookings` | Auth + Admin roles | Create/manage bookings, contracts, payments |
| `VehiclesController` | `/api/vehicles` | Public read, admin write | Vehicle CRUD, images, attributes, models |
| `DashboardController` | `/api/dashboard` | Admin only | Analytics, revenue stats, branch overview |
| `UsersController` | `/api/users` | Auth + admin | User management, profiles, roles |
| `RolesController` | `/api/roles` | Admin | Role CRUD and claims |
| `LocationsController` | `/api/locations` | Admin | Branch/location management |
| `PaymentsController` | `/api/payments` | Public | Payment methods |
| `WebhooksController` | `/api/webhooks` | Anonymous | External payment callbacks |
| `EkycController` | `/api/ekyc` | Authenticated | Identity verification (VNPT) |
| `RefundRequestsController` | `/api/refund-requests` | Auth + admin | Refund processing |
| `ViolationsController` | `/api/violations` | Admin | Violation tracking |
| `InsurancesController` | `/api/insurances` | Public/Admin | Insurance packages |
| `FuelsController` | `/api/fuels` | Admin | Fuel type management |
| `TransmissionsController` | `/api/transmissions` | Admin | Transmission management |
| `VehicleCategoriesController` | `/api/vehicle-categories` | Admin | Category management |
| `SystemSettingsController` | `/api/system-settings` | Admin | System configuration |
| `TermsController` | `/api/terms` | Public | Terms & conditions |
| `PermissionsController` | `/api/permissions` | Admin | Permission listing |

### Response Format

All API responses use a consistent `ApiResponse` wrapper:

```json
{
  "success": true,
  "message": "Operation successful",
  "data": { ... },
  "errors": null
}
```

Error responses:

```json
{
  "success": false,
  "message": "Error description",
  "data": null,
  "errors": ["Specific error detail"]
}
```

### Real-time Notifications

SignalR hub available at `/hubs/notification` with JWT authentication via query string:

```javascript
const connection = new signalR.HubConnectionBuilder()
  .withUrl("/hubs/notification?access_token=YOUR_JWT_TOKEN")
  .build();
```

---

## External Integrations

| Service | Purpose | Configuration |
|---------|---------|---------------|
| **PayOS** | Payment gateway (Vietnam) | `PayOsSettings` (ClientId, ApiKey, ChecksumKey) |
| **VnPay** | Payment gateway | `VnPaySettings` |
| **VNPT eKYC** | Identity verification (CCCD, face match, liveness) | `VnptEkycSettings` |
| **Cloudinary** | Image CDN for vehicle photos & avatars | `CloudinarySettings` |
| **MinIO** | Object storage for documents & contracts | `MinioSettings` |
| **Twilio** | SMS notifications | `TwilioSettings` |
| **SpeedSMS** | Alternative SMS provider | `SpeedSmsSettings` |
| **Gmail API / SMTP** | Email delivery (booking confirmations, promotions) | `EmailSettings`, `GmailApiSettings` |
| **Google OAuth** | Social login | `GoogleSettings` |
| **Semantic Kernel** | AI-powered features (text embeddings, image verification) | gRPC services |

---

## Development Conventions

### Code Style

- **Nullable reference types** enabled across all projects
- **Implicit usings** enabled
- **File-scoped namespaces** preferred
- **Async/await** for all I/O operations

### Architecture Rules

- **Controllers are thin** – they only map DTOs via AutoMapper and dispatch via MediatR `ISender` or `TaskQueue`
- **No business logic in controllers** – all logic lives in Application layer handlers
- **Domain layer is pure** – no external dependencies, only interfaces
- **Infrastructure depends on Domain & Application** – never the reverse
- **Strategy Pattern for extensibility** – new payment methods or email templates are added as new strategy classes without modifying existing code
- **TaskQueue for high-traffic endpoints** – bounded channel with configurable worker pool prevents thread explosion under load

### Folder Structure (Features)

```
Features/
└── Bookings/
    ├── Commands/
    │   ├── CreateBookingCommand.cs
    │   ├── CreateBookingCommandHandler.cs
    │   └── CreateBookingCommandValidator.cs
    ├── Queries/
    │   ├── GetBookingsPagedQuery.cs
    │   └── GetBookingsPagedQueryHandler.cs
    ├── DTOs/
    └── Events/
        ├── BookingCreatedEvent.cs
        └── BookingCreatedConsumer.cs
```

### Error Handling

The `GlobalInfrastructureMiddleware` centrally handles exceptions:

| Exception Type | HTTP Status |
|---------------|-------------|
| `ValidationException` | 400 |
| `DomainException` | Custom (from exception) |
| `DbUpdateConcurrencyException` | 409 |
| `OperationCanceledException` | 499 |
| `TimeoutException` | 504 |
| SQL errors (duplicates, FK, deadlock) | Mapped appropriately |

---

## Code Quality

- **Qodana** (JetBrains static analysis) – configured in `qodana.yaml`
- **JetBrains Rider** – primary IDE (`.idea/` directory present)
- **Swagger** – API documentation with custom CSS styling

---

## Project Structure

```
NET_CarRentalSystem/
├── NET_CarRentalSystem/                    # API (Presentation Layer)
│   ├── Controllers/                        # 20 API controllers
│   ├── Middlewares/                        # Global exception handling
│   ├── Extensions/                         # DI, migrations, rate limiting, SignalR
│   ├── Mappings/                           # 18 AutoMapper profiles
│   ├── Models/                             # Request/Response DTOs
│   ├── Attributes/                         # Custom action attributes
│   ├── appsettings.json                    # Configuration
│   ├── Dockerfile                          # Container build
│   └── Program.cs                          # Entry point
├── NET_CarRentalSystem.Domain/             # Domain Layer (Core)
│   ├── Entities/                           # 33 domain entities
│   ├── Enums/                              # 22 enumeration types
│   ├── Exceptions/                         # Provider-specific exceptions
│   ├── Interfaces/                         # Repository & persistence interfaces
│   ├── Constants/                          # Permissions, roles, settings
│   └── Common/                             # BaseEntity, IAuditable, ISoftDelete
├── NET_CarRentalSystem.Application/        # Application Layer
│   ├── Features/                           # 20 feature modules (CQRS)
│   ├── Common/                             # Behaviors, events, base interfaces
│   ├── Configurations/                     # 18 typed settings classes
│   ├── Interfaces/                         # Service abstractions (12 categories)
│   └── Models/                             # DTOs, notification models
├── NET_CarRentalSystem.Infrastructure/     # Infrastructure Layer
│   ├── Persistence/                        # EF Core DbContexts, repositories, migrations
│   ├── Services/                           # Identity, Token, Email, Cloudinary, VNPT eKYC
│   ├── DependencyInjection/                # DI registration modules
│   ├── Hubs/                               # SignalR NotificationHub
│   ├── gRPC/                               # gRPC channel factory, proto files
│   ├── Http/                               # HTTP client configurations
│   └── Protos/                             # image_analysis.proto, text_embedding.proto
├── NET_CarRentalSystem.Shared/             # Shared Utilities
│   ├── Constants/                          # App-wide constants
│   ├── Utilities/                          # DateTime, Enum, JSON, Reflection helpers
│   ├── CoreHelpers/                        # Cache key, OTP, Token, Transaction helpers
│   ├── Wrapper/                            # ApiResponse pattern
│   └── Pagination/                         # PagedList<T>
├── NET_CarRentalSystem.SyncDataTool/       # Background Sync Service
│   ├── Worker.cs                           # SQL Server Change Tracking sync
│   ├── Services/                           # Merge statement builder, metadata cache
│   ├── appsettings.json                    # Sync configuration
│   └── Dockerfile                          # Container build
├── Scripts/                                # Database seed scripts
│   ├── seed_writedb.sql
│   ├── seed_writedb_comprehensive.sql
│   ├── seed_readdb.sql
│   └── seed_readdb_comprehensive.sql
├── Models/                                 # ML model files (ONNX, etc.)
├── docker-compose.yml                      # Full stack orchestration
├── docker-compose.override.yml             # Development overrides
├── NET_CarRentalSystem.sln                 # Visual Studio solution
└── README.md                               # This file
```

---

## Sync Data Tool

The `SyncDataTool` is a background worker that keeps the read database in sync with the write database using **SQL Server Change Tracking**:

1. Polls configured tables every `SyncIntervalInSeconds` (default: 2s)
2. Reads changes from `CHANGETABLE()` since `LastSyncVersion`
3. Applies MERGE statements (upsert) or DELETE statements to the read database
4. Handles IDENTITY columns, SQL DateTime minimums, and retry logic

---

## License

Internal project – proprietary.
