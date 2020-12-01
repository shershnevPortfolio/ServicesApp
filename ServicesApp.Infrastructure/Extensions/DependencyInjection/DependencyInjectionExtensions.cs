using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Core.Commands;
using ServicesApp.Core.CommandsHandlers;
using ServicesApp.Core.Services;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ServicesApp.Core.Factories;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Infrastructure.Visiters;

namespace ServicesApp.Infrastructure.Extentions.DependencyInjection
{
    public static class DependencyInjectionExtentions
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICommandVisiter, CommandQueryVisiter>();
            return services;
        }
    }
}
