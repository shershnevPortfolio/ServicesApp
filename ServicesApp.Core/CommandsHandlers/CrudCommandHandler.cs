using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
   internal abstract class CrudCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : CrudCommand
   {
        protected readonly IUnitOfWork _unitOfWork;

        protected CrudCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task Handle(TCommand command)
        {
            var commandForDal = (CrudCommand)command;
            await _unitOfWork.ExecuteCrudCommand(commandForDal);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
