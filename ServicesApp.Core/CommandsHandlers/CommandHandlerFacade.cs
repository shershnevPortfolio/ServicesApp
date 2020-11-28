using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandsHandlers
{
    public class CommandHandlerFacade: ICommandHandler
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly ICommandHandlerFactory _commandHandlerFactory;

        public CommandHandlerFacade(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _commandHandlerFactory = _serviceProvider.GetService<ICommandHandlerFactory>();
        }


        public async Task Handle<TCommand> (TCommand command) where TCommand : BaseCommand
        {
            var handler = _commandHandlerFactory.CreateHandlerFor<TCommand>();
            await handler.Handle(command);
        }
    }
}
