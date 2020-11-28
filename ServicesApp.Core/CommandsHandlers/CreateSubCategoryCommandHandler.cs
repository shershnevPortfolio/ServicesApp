using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
    class CreateSubCategoryCommandHandler : ICommandHandler<CreateSubCategoryCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateSubCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = _unitOfWork;
        }

        public Task Handle(CreateSubCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
