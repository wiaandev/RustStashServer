using RustStashServer.Core.Services;

namespace RustStashServer.Core
{
    using Microsoft.EntityFrameworkCore;

    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
                options.EnableDetailedErrors();
            });

            services.AddDbContext<AppDbContext>();
            return services;
        }

        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();

            return services;
        }
    }

}