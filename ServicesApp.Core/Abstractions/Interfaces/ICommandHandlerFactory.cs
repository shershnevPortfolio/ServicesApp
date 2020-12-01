using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> CreateHandlerFor<TCommand>() where TCommand : BaseCommand;
    }
}
