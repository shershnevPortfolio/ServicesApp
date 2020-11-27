using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Commands;
using ServicesApp.Core.CommandsHandlers;
using ServicesApp.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Linq;

namespace ServicesApp.Core.Factories
{
    internal class CommandHandlerFactory : ICommandHandlerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ICommandHandler<TCommand> CreateHandlerFor<TCommand>()
        {

            return _serviceProvider.GetService<ICommandHandler<TCommand>>();
        }   
    }
}
