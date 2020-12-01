using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Core.Commands;
using ServicesApp.Core.CommandsHandlers;
using ServicesApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ServicesApp.Core.Factories;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Infrastructure.Visitors;
using ServicesApp.Infrastructure.Repositories;
using ServicesApp.Infrastructure.Abstractions.Interfaces;

namespace ServicesApp.Infrastructure.Extentions.DependencyInjection
{
    public static class DependencyInjectionExtentions
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICommandVisitor, CommandQueryVisitor>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.Scan(scan =>
            {
                scan.FromCallingAssembly()
                .AddClasses(classes => classes.AssignableTo(typeof(IRepositoryFactory<>)))
                .AsImplementedInterfaces();

            });
            return services;
        }
    }
}
