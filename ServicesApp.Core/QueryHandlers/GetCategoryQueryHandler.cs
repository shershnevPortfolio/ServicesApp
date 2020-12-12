using System;
using System.Collections.Generic;
using System.Text;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.QueryHandlers;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Queries;

namespace ServicesApp.Core.QueryHandlers
{
    class GetCategoryQueryHandler : GetSingleQueryHandler<GetCategoryQuery, CategoryDTO, Category>
    {
        public GetCategoryQueryHandler(IQueryHandlerService<Category> handlerService) : base(handlerService)
        {
        }
    }
}
