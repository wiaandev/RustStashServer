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
        services.AddIdentity<User, Role>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddRoles<Role>()
            .AddClaimsPrincipalFactory<CustomUserClaimsPrincipalFactory>()
            .AddDefaultTokenProviders();

        // TODO: Add Google SSO
        // services.AddAuthentication()
        //     .AddGoogle(opts =>
        //     {
        //         opts.ClientId = configuration["Authentication:Google:ClientId"]!;
        //         opts.ClientSecret = configuration["Authentication:Google:ClientSecret"]!;
        //     });
    }
}