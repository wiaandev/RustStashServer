// <copyright file="IServiceCollectionExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.


namespace RustStashServer.Core;
using Microsoft.EntityFrameworkCore;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPooledDbContextFactory<AppDbContext>(
            options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
            });

        services.AddDbContext<AppDbContext>();
        return services;
    }

    //public static IServiceCollection AddCoreServices(this IServiceCollection services)
    //{
    //    services.AddScoped
    //}
}