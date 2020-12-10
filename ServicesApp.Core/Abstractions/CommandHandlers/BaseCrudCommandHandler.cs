using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    internal abstract class BaseCrudCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : CrudCommand
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected readonly ICommandVisitor _visiter;

        protected BaseCrudCommandHandler(IUnitOfWork unitOfWork, ICommandVisitor visiter)
        {
            _unitOfWork = unitOfWork;
            _visiter = visiter;
        }

        public abstract Task Handle(TCommand command);
       
    }
}
