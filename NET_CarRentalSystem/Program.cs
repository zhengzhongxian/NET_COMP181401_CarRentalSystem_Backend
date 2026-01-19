using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Middlewares;
using NET_CarRentalSystem.Shared.Constants;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

builder.Host.UseSerilog((context, config) =>
    config.ReadFrom.Configuration(context.Configuration));

services.AddProjectServices(configuration);

services.AddWebApiServices(configuration);

services.AddRateLimitingServices();

services.AddEndpointsApiExplorer();

var app = builder.Build();

app.InitializeQueryExecutor();

_ = app.ApplyMigrationsAsync();

app.InitializeRediSearchIndex();

app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.InjectStylesheet("/css/swagger-custom.css");
});

app.UseMiddleware<GlobalInfrastructureMiddleware>();
app.UseRateLimitingMiddleware();
app.UseHttpsRedirection();
app.UseSerilogRequestLogging();
app.UseCors(AppConstants.CorsPolicy.DefaultCorsPolicy);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseSignalRHubs();

app.Run();