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
    class GetOrdersQueryHandler : GetEnumerableQueryHandler<GetOrdersQuery, IEnumerable<OrderDTO>, Order>
    {
        public GetOrdersQueryHandler(IQueryHandlerService<Order> handlerService) : base(handlerService)
        {
        }
    }
}
