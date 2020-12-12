using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> CreateHandlerFor<TCommand>() where TCommand : BaseCommand;

        IQueryHandler<TQuery, TResult> CreateHandlerFor<TQuery, TResult>() where TQuery : BaseQuery<TResult>;
    }
}
