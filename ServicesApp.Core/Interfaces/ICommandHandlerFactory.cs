using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Interfaces
{
    internal interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> CreateHandlerFor<TCommand>();
    }
}
