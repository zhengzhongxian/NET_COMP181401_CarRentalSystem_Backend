using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Infrastructure.Configuration;
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
                
                var errorResponse = ApiResponse<string>.ErrorResult(
                    combinedErrorMessage,
                    StatusCodes.Status400BadRequest,
                    null
                );
                
                return new BadRequestObjectResult(errorResponse);
            };
        });
        
        var jwtSettings = configuration.GetSection(JwtSettings.SectionName).Get<JwtSettings>();
        
        using var serviceProvider = services.BuildServiceProvider();
        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
        
        if (jwtSettings == null)
        {
            logger.LogError("JWT settings not found in configuration section: {Section}", 
                KeyConstants.ConfigurationSections.JwtSettings);
            throw new InvalidOperationException(
                $"Missing configuration section: {KeyConstants.ConfigurationSections.JwtSettings}");
        }

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(o =>
        {
            o.TokenValidationParameters = new TokenValidationParameters
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

        return services;
    }
}
