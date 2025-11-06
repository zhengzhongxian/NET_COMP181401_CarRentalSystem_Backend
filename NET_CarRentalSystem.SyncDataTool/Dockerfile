FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NET_CarRentalSystem.SyncDataTool/NET_CarRentalSystem.SyncDataTool.csproj", "NET_CarRentalSystem.SyncDataTool/"]
COPY ["NET_CarRentalSystem.Shared/NET_CarRentalSystem.Shared.csproj", "NET_CarRentalSystem.Shared/"]
RUN dotnet restore "NET_CarRentalSystem.SyncDataTool/NET_CarRentalSystem.SyncDataTool.csproj"
COPY . .
WORKDIR "/src/NET_CarRentalSystem.SyncDataTool"
RUN dotnet build "./NET_CarRentalSystem.SyncDataTool.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NET_CarRentalSystem.SyncDataTool.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NET_CarRentalSystem.SyncDataTool.dll"]
