using NET_CarRentalSystem.SyncService;
using NET_CarRentalSystem.SyncService.Services;
using Serilog;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<SyncTableMetadataCache>();   
builder.Services.AddHostedService<Worker>();

builder.Services.AddSerilog(config =>
    config.ReadFrom.Configuration(builder.Configuration));

var host = builder.Build();
host.Run();
