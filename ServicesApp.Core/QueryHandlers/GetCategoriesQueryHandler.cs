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
    internal class GetCategoriesQueryHandler : GetEnumerableQueryHandler<GetCategoriesQuery, IEnumerable<CategoryDTO>, Category>
    {
        public GetCategoriesQueryHandler(IQueryHandlerService<Category> handlerService) : base(handlerService)
        {
        }
    }
}
