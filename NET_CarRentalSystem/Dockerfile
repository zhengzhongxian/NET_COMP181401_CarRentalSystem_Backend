FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NET_CarRentalSystem/NET_CarRentalSystem.API.csproj", "NET_CarRentalSystem/"]
COPY ["NET_CarRentalSystem.Application/NET_CarRentalSystem.Application.csproj", "NET_CarRentalSystem.Application/"]
COPY ["NET_CarRentalSystem.Domain/NET_CarRentalSystem.Domain.csproj", "NET_CarRentalSystem.Domain/"]
COPY ["NET_CarRentalSystem.Shared/NET_CarRentalSystem.Shared.csproj", "NET_CarRentalSystem.Shared/"]
COPY ["NET_CarRentalSystem.Infrastructure/NET_CarRentalSystem.Infrastructure.csproj", "NET_CarRentalSystem.Infrastructure/"]
RUN dotnet restore "NET_CarRentalSystem/NET_CarRentalSystem.API.csproj"
COPY . .
WORKDIR "/src/NET_CarRentalSystem"
RUN dotnet build "./NET_CarRentalSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NET_CarRentalSystem.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NET_CarRentalSystem.API.dll"]