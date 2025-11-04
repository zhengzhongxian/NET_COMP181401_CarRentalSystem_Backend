using NET_CarRentalSystem.SyncDataTool;
using NET_CarRentalSystem.SyncDataTool.Configurations;
using NET_CarRentalSystem.SyncDataTool.Services;
using Serilog;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<SyncTableMetadataCache>();   
builder.Services.AddHostedService<Worker>();

builder.Services.AddSerilog(config =>
    config.ReadFrom.Configuration(builder.Configuration));

builder.Services.Configure<SyncDataToolSettings>(
    builder.Configuration.GetSection(SyncDataToolSettings.SectionName)
);

var host = builder.Build();
host.Run();
