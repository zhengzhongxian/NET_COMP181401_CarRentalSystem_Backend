using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NET_CarRentalSystem.API.Middlewares;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Extensions;

public static class WebApiServiceRegistration
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(cfg =>
        {
            cfg.AddMaps(Assembly.GetExecutingAssembly());
        });

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Renticar API", Version = "v1" });

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = @"Enter JWT Access Token here to authenticate. <br/>
                        Exp: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                    },
                    new List<string>()
                }
            });
        });

        services.AddControllers()
        .ConfigureApiBehaviorOptions(options =>
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var errors = context.ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                var combinedErrorMessage = string.Join("; ", errors);
                if (string.IsNullOrEmpty(combinedErrorMessage))
                {
                    combinedErrorMessage = "Lỗi xác thực không xác định.";
                }

                var errorResponse = ApiResponse.ErrorResult(combinedErrorMessage);

                return new BadRequestObjectResult(errorResponse);
            };
        });
        
        using var serviceProvider = services.BuildServiceProvider();

        var jwtSettings = serviceProvider.GetRequiredService<IOptions<JwtSettings>>().Value;
        
        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

        if (jwtSettings == null)
        {
            logger.LogError("JWT settings not found in configuration section: {Section}",
                KeyConstants.ConfigurationSections.JwtSettings);
            throw new InvalidOperationException(
                $"Missing configuration section: {KeyConstants.ConfigurationSections.JwtSettings}");
        }
        
        var googleSettings = serviceProvider.GetRequiredService<IOptions<GoogleSettings>>().Value;
        
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddGoogle(options =>
        {
            options.ClientId = googleSettings.ClientId;
            options.ClientSecret = googleSettings.ClientSecret;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings.Issuer,
                ValidAudience = jwtSettings.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key))
            };
        });

        services.AddAuthorization(options =>
        {
            foreach (var permission in PermissionConstants.GetAllPermissions())
            {
                options.AddPolicy(permission, policy =>
                    policy.RequireClaim("Permission", permission));
            }
        });
        
        var corsSettings = serviceProvider.GetRequiredService<IOptions<CorsSettings>>().Value;

        services.AddCors(options =>
        {
            const string defaultPolicyName = AppConstants.CorsPolicy.DefaultCorsPolicy;

            var allOrigins = corsSettings.Policies.Values
                .Where(p => p.Origins != null && p.Origins.Length > 0)
                .SelectMany(p => p.Origins!)
                .Where(o => !string.IsNullOrWhiteSpace(o))
                .Distinct()
                .ToArray();

            var allMethods = corsSettings.Policies.Values
                .Where(p => p.Methods != null && p.Methods.Length > 0)
                .SelectMany(p => p.Methods!)
                .Where(m => !string.IsNullOrWhiteSpace(m))
                .Distinct()
                .ToArray();

            var allHeaders = corsSettings.Policies.Values
                .Where(p => p.Headers != null && p.Headers.Length > 0)
                .SelectMany(p => p.Headers!)
                .Where(h => !string.IsNullOrWhiteSpace(h))
                .Distinct()
                .ToArray();

            var allowCredentials = corsSettings.Policies.Values.Any(p => p.AllowCredentials);

            logger.LogInformation("CORS Configuration - Origins: [{Origins}], Methods: [{Methods}], Headers: [{Headers}], AllowCredentials: {AllowCredentials}",
                string.Join(", ", allOrigins),
                string.Join(", ", allMethods),
                string.Join(", ", allHeaders),
                allowCredentials);

            if (allOrigins.Length > 0)
            {
                options.AddPolicy(defaultPolicyName, builder =>
                {
                    var isAnyOrigin = allOrigins.Contains("*");
                    var isAnyMethod = allMethods.Length == 0 || allMethods.Contains("*");
                    var isAnyHeader = allHeaders.Length == 0 || allHeaders.Contains("*");
                    
                    if (isAnyOrigin)
                    {
                        builder.AllowAnyOrigin();
                    }
                    else
                    {
                        builder.WithOrigins(allOrigins);
                    }
                    
                    if (isAnyMethod)
                    {
                        builder.AllowAnyMethod();
                    }
                    else
                    {
                        builder.WithMethods(allMethods);
                    }
                    
                    if (isAnyHeader)
                    {
                        builder.AllowAnyHeader();
                    }
                    else
                    {
                        builder.WithHeaders(allHeaders);
                    }
                    
                    if (allowCredentials && !isAnyOrigin)
                    {
                        builder.AllowCredentials();
                    }
                });
            }
            else
            {
                logger.LogWarning("No CORS origins configured, using default localhost origins");
                options.AddPolicy(defaultPolicyName, builder =>
                {
                    builder.WithOrigins("http://localhost:5173", "https://localhost:5173")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            }
        });
        
        services.AddTransient<GlobalInfrastructureMiddleware>();
        
        return services;
    }
}
