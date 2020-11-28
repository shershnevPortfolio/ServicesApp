using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Abstractions.Interfaces;

namespace ServicesApp.Core.CommandsHandlers
{
    class CrudCommandHandler<TCommand> : BaseCrudCommandHandler<TCommand> where TCommand : CrudCommand
    {
        public CrudCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
