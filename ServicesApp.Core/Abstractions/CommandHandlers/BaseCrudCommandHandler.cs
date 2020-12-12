using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Abstractions.Commands;

namespace ServicesApp.Core.Abstractions.CommandHandlers
{
    internal abstract class BaseCrudCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : CrudCommand
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseCrudCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public abstract Task Handle(TCommand command);
       
    }
}
