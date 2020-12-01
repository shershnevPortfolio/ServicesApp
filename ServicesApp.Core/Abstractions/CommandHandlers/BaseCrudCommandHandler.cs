using ServicesApp.Core.Abstractions.Commands;
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

        protected readonly ICommandVisiter _visiter;

        protected BaseCrudCommandHandler(IUnitOfWork unitOfWork, ICommandVisiter visiter)
        {
            _unitOfWork = unitOfWork;
            _visiter = visiter;
        }

        public virtual async Task Handle(TCommand command)
        {
            await command.Accept(_visiter);
        }
    }
}
