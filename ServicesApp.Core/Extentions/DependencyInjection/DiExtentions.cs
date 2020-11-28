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

namespace ServicesApp.Core.Extentions.DependencyInjection
{
    public static class DiExtentions
    {
        public static IServiceCollection AddDomainDependencies(this IServiceCollection services)
        {
            services.Scan(scan =>
            {
                scan.FromCallingAssembly()
                .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<>)))
                .AsImplementedInterfaces()

                ;


            });

            services.AddTransient<ICommandHandler, CommandHandlerFacade>();
            services.AddTransient<ISubCategoryService, SubCategoryService>();
            services.AddTransient<IResultCreationService, ResultCreationService>();
            services.AddTransient<IValidationService, ValidationService>();
            services.AddScoped<ICommandHandlerFactory, CommandHandlerFactory>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();

            return services;
         
        }
    }
}
