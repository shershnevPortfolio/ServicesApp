using ServicesApp.Core.Commands;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Core.CommandsHandlers
{
    internal class GetCategoryCommandHandler : CrudCommandHandler<GetCategoryCommand>
    {
        public GetCategoryCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
