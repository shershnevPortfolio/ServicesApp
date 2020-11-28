using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
    class GetSubcategoriesCommandHandler : ICommandHandler<GetSubcategoriesCommand>
    {
        public async Task Handle(GetSubcategoriesCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
