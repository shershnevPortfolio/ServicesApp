using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Core.Queries;
using ServicesApp.Core.CommandHandlers;
using ServicesApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using MediatR;
using MediatR.Pipeline;

namespace ServicesApp.Core.Extentions.DependencyInjection
{
    public static class DependencyInjectionExtentions
    {
        public static IServiceCollection AddDomainDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidationService, ValidationService>();
            services.AddTransient(typeof(ICommandHandlerService<>), typeof(CommandHadnlerService<>));
            services.AddTransient<IResultCreationService, ResultCreationService>();
            services.AddTransient<IValidationService, ValidationService>();
            services.AddTransient(typeof(ICommandHandlerService<>), typeof(CommandHadnlerService<>));
            services.AddTransient(typeof(IQueryHandlerService<>), typeof(QueryHandlerService<>));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
         
        }
    }
}
