using ServicesApp.Core.Abstractions.QueryHandlers;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.QueryHandlers
{
    class GetSubcategoryQueryHandler : GetSingleQueryHandler<GetSubcategoryQuery, SubcategoryDTO, Subcategory>
    {
        public GetSubcategoryQueryHandler(Abstractions.Interfaces.IQueryHandlerService<Subcategory> handlerService) : base(handlerService)
        {
        }
    }
}
