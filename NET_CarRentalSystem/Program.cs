using NET_CarRentalSystem.API.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

builder.Host.UseSerilog((context, config) =>
    config.ReadFrom.Configuration(context.Configuration));

services.AddProjectServices(configuration);

services.AddWebApiServices(configuration);

services.AddEndpointsApiExplorer();

var app = builder.Build();

_ = app.ApplyMigrationsAsync();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseSerilogRequestLogging();
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();