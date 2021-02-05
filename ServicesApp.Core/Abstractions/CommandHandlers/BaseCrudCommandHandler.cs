using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Commands;
using MediatR;
using System.Threading;
using Ardalis.Result;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    internal abstract class BaseCrudCommandHandler<TCommand> : IRequestHandler<TCommand, Result<Unit>>
        where TCommand : BaseCommand
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseCrudCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public abstract Task<Result<Unit>> Handle(TCommand request, CancellationToken cancellationToken);
    }
}
