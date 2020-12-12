using Ardalis.Result;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface ICommandHandler<TCommand> where TCommand : BaseCommand
    {
        Task Handle(TCommand command);

    }

    public interface ICommandHandler
    {
        Task Handle<TCommand>(TCommand command) where TCommand : BaseCommand;

        Task<Result<TResult>> Handle<TQuery, TResult>(TQuery query) where TQuery : BaseQuery<TResult>;
    }
}
