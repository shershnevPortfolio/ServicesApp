using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServicesApp.Core.Entities
{
    public class Category : BaseEntity
    {
       public string  Name { get; set;} 

       public virtual List<SubCategory> SubCategories { get; set; }
    }
}
