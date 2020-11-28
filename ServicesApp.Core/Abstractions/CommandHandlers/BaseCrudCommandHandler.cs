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

        protected BaseCrudCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task Handle(TCommand command)
        {
            var commandForDal = command;
            await _unitOfWork.ExecuteCrudCommand(commandForDal);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
