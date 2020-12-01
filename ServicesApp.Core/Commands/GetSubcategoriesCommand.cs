using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Entities;
using ServicesApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Commands
{
    public class GetSubcategoriesCommand : GetEnumerableCommand<Subcategory>
    {
    }
}
