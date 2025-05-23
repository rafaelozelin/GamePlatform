﻿using GamePlatform.Application.Interfaces.Services;
using GamePlatform.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GamePlatform.Application.Configuration;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IJogoService, JogoService>();

        services.AddScoped<IUsuarioContextService, UsuarioContextService>();

        return services;
    }
}
