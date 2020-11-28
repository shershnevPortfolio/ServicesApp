using ServicesApp.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Interfaces
{
    internal interface ICommandHandler<TCommand> where TCommand : BaseCommand
    {
        Task Handle(TCommand command);

    }

    public interface ICommandHandler
    {
        Task Handle<TCommand>(TCommand command) where TCommand : BaseCommand ;
    }
}
