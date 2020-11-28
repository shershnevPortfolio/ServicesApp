using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Linq;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.Commands;

namespace ServicesApp.Core.Factories
{
    internal class CommandHandlerFactory : ICommandHandlerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ICommandHandler<TCommand> CreateHandlerFor<TCommand>() where TCommand : BaseCommand
        {
            return _serviceProvider.GetService<ICommandHandler<TCommand>>();
        }   
    }
}
