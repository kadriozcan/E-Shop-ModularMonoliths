﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Add services to the DI container


        // 1. Api Endpoint services

        // 2. Application Use Case services

        // 3. Data - Infrastructure services
        var connectionString = configuration.GetConnectionString("Database");

        services.AddDbContext<CatalogDbContext>(options =>
            options.UseNpgsql(connectionString));

        services.AddScoped<IDataSeeder, CatalogDataSeeder>();

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // Configure HTTP request pipeline


        // 1. Use Api Endpoint services

        // 2. Use Application Use Case Services

        // 3. Use Data - Infrastructure services
        app.UseMigration<CatalogDbContext>();


        return app;
    }
}
