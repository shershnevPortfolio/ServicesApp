using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Interfaces
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> CreateHandlerFor<TCommand>();
    }
}
