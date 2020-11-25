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
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        public CommandHandlerFactory()
        {
            
        }

        public ICommandHandler<TCommand> CreateHandlerFor<TCommand>()
        {
            var types  = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ICommandHandler<TCommand>)));
            return (ICommandHandler<TCommand>)Activator.CreateInstance(types.First());

        }   
    }
}
