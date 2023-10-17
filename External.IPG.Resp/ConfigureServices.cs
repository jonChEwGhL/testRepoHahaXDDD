using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using Infrastructure;
using ZymLabs.NSwag.FluentValidation;
using External.IPG.Resp.Filter;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    private static IConfiguration Configuration { get; set; }
    public static IServiceCollection AddWebUIServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDatabaseDeveloperPageExceptionFilter();

        Configuration = configuration;
        services.AddHttpContextAccessor();
        services.AddHttpClient("TNGD", httpClient =>
        {
            httpClient.BaseAddress = new Uri(configuration.GetValue<string>("Internal:BasePath"));
        });
        services.AddHttpClient("IPG", httpClient =>
        {
            httpClient.BaseAddress = new Uri(configuration.GetValue<string>("IPG:Path"));
        });
        services.AddApplicationServices(configuration);
        services.AddInfrastructureServices(configuration);
        services.AddControllers(options =>
        {
            options.Filters.Add<ApiExceptionFilterAttribute>(); // Add ApiExceptionFilterAttribute as a global filter
        });
        services.AddEndpointsApiExplorer();
        services.AddHealthChecks();
        //.AddDbContextCheck<ApplicationDbContext>();

        services.AddScoped<FluentValidationSchemaProcessor>(provider =>
        {
            var validationRules = provider.GetService<IEnumerable<FluentValidationRule>>();
            var loggerFactory = provider.GetService<ILoggerFactory>();

            return new FluentValidationSchemaProcessor(provider, validationRules, loggerFactory);
        });

        // Customise default API behaviour
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = Assembly.GetEntryAssembly()?.GetName().Name,
                Version = "v1"
            });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
        });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = false, // on production make it true
                ValidateAudience = false, // on production make it true
                ValidAudience = Configuration["Jwt:Audience"],
                ValidIssuer = Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            };
        });
        // Add authorization services (if needed)
        services.AddAuthorization();
        return services;
    }
}