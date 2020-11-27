using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ServicesApp.Core.Interfaces;


namespace ServicesApp.Core.CommandsHandlers
{
    public class CommandHandlerFacade: ICommandHandler
    {
        private readonly ICommandHandlerFactory _commandHandlerFactory;

        public CommandHandlerFacade(ICommandHandlerFactory commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
        }

        public void Handle<TCommand>(TCommand command)
        {
            var handler = _commandHandlerFactory.CreateHandlerFor<TCommand>();
            handler.Handle(command);

        }
    }
}
