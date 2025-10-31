FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NET_CarRentalSystem.SyncService/NET_CarRentalSystem.SyncService.csproj", "NET_CarRentalSystem.SyncService/"]
COPY ["NET_CarRentalSystem.Infrastructure/NET_CarRentalSystem.Infrastructure.csproj", "NET_CarRentalSystem.Infrastructure/"]
COPY ["NET_CarRentalSystem.Application/NET_CarRentalSystem.Application.csproj", "NET_CarRentalSystem.Application/"]
COPY ["NET_CarRentalSystem.Domain/NET_CarRentalSystem.Domain.csproj", "NET_CarRentalSystem.Domain/"]
COPY ["NET_CarRentalSystem.Shared/NET_CarRentalSystem.Shared.csproj", "NET_CarRentalSystem.Shared/"]

RUN dotnet restore "NET_CarRentalSystem.SyncService/NET_CarRentalSystem.SyncService.csproj"
COPY . .
WORKDIR "/src/NET_CarRentalSystem.SyncService"
RUN dotnet build "./NET_CarRentalSystem.SyncService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NET_CarRentalSystem.SyncService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NET_CarRentalSystem.SyncService.dll"]
