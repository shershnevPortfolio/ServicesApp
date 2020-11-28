using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
    class GetSubcategoryCommandHandler : ICommandHandler<CreateSubCategoryCommand>
    {
        public async Task Handle(CreateSubCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
