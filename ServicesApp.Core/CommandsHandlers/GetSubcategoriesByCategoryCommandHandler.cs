using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;

namespace ServicesApp.Core.CommandsHandlers
{
    class GetSubcategoriesByCategoryCommandHandler : ICommandHandler<GetSubcategoriesByCategoryCommand>
    {
        public async Task Handle(GetSubcategoriesByCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
