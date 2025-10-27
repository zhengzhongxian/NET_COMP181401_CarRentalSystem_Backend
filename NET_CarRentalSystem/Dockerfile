# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Stage Base (Dùng cho Debug nhanh)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

EXPOSE 8080
EXPOSE 8081
EXPOSE 443 

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NET_CarRentalSystem/NET_CarRentalSystem.API.csproj", "NET_CarRentalSystem/"]
COPY ["NET_CarRentalSystem.Infrastructure/NET_CarRentalSystem.Infrastructure.csproj", "NET_CarRentalSystem.Infrastructure/"]
COPY ["NET_CarRentalSystem.Application/NET_CarRentalSystem.Application.csproj", "NET_CarRentalSystem.Application/"]
COPY ["NET_CarRentalSystem.Domain/NET_CarRentalSystem.Domain.csproj", "NET_CarRentalSystem.Domain/"]
COPY ["NET_CarRentalSystem.Shared/NET_CarRentalSystem.Shared.csproj", "NET_CarRentalSystem.Shared/"]
RUN dotnet restore "./NET_CarRentalSystem/NET_CarRentalSystem.API.csproj"
COPY . .
WORKDIR "/src/NET_CarRentalSystem"
RUN dotnet build "./NET_CarRentalSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NET_CarRentalSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final 
WORKDIR /app

RUN apt-get update && apt-get install -y \
    curl \
    && rm -rf /var/lib/apt/lists/*

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NET_CarRentalSystem.API.dll"]