using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Interfaces;
using ServicesApp.Core.Commands;
using System.Threading.Tasks;
using AutoMapper;
using ServicesApp.Core.Entities;

namespace ServicesApp.Core.CommandsHandlers
{
    internal class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand>
    {
        public Task Handle(CreateCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
