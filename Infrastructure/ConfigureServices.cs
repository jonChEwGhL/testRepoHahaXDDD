using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            Assembly sourceAssembly = typeof(ConfigureServices).Assembly;
            //services.AddScoped<IOAuthServices, OAuthServices>();
            //services.AddScoped<IAcquiringServices, AcquiringServices>();

            return services;
        }
    }
}
