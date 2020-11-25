using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;


namespace ServicesApp.Core.Proxies
{
    public class CommandHandlerProxy<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandlerFactory _commandHandlerFactory;
        private readonly ICommandHandler<TCommand> _commandHandler;

        public CommandHandlerProxy(ICommandHandlerFactory commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
            _commandHandler = _commandHandlerFactory.CreateHandlerFor<TCommand>();
        }

        public void Handle(TCommand command)
        {
            _commandHandler.Handle(command);
        }
    }
}
