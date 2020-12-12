using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Abstractions.QueryHandlers;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.QueryHandlers
{
    class GetSubcategoriesQueryHandler : GetEnumerableQueryHandler<GetSubcategoriesQuery, IEnumerable<SubcategoryDTO>, Subcategory>
    {
        public GetSubcategoriesQueryHandler(IQueryHandlerService<Subcategory> handlerService) : base(handlerService)
        {
        }
    }
}
