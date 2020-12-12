using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.DTOs;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Queries
{
    public class GetCategoriesQuery : GetEnumerableQuery<IEnumerable<CategoryDTO>>
    {
    }
}
