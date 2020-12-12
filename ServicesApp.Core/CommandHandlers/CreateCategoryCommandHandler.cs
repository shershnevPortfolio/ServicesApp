using ServicesApp.Core.Abstractions.CommandHandlers;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Commands;

namespace ServicesApp.Core.CommandHandlers
{
    internal class CreateCategoryCommandHandler : CreateCommandHandler<CreateCategoryCommand, Category>
    {
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, ICommandHandlerService<Category> commandHandlerService) 
            : base(unitOfWork,  commandHandlerService)
        {

        }

    }
}
