using MailKit;
using Microsoft.AspNetCore.Identity;
using RustStashServer.Core.Entities.Auth;
using RustStashServer.Core.Services;

namespace RustStashServer.Core;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        // services.AddScoped<EmailTemplateService>();
        // services.AddSingleton<IMailService, MailService>();
        services.AddScoped<UserService>();
        services.AddSingleton<SeedService>();

        return services;
    }

    public static void AddAuth(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddIdentityCore<User>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
            })
            .AddEntityFrameworkStores<RustStashDbContext>()
            .AddRoles<Role>()
            .AddClaimsPrincipalFactory<CustomUserClaimsPrincipalFactory>()
            .AddDefaultTokenProviders();

        services.AddAuthentication()
            .AddGoogle(opts =>
            {
                opts.ClientId = configuration["Authentication:Google:ClientId"] !;
                opts.ClientSecret = configuration["Authentication:Google:ClientSecret"] !;
            });
    }
}