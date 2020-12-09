using ServicesApp.Core.Abstractions.Commands;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface ICommandHandler<in TCommand> where TCommand : BaseCommand
    {
        Task Handle(TCommand command);

    }

    public interface ICommandHandler
    {
        Task Handle<TCommand>(TCommand command) where TCommand : BaseCommand;
    }
}
