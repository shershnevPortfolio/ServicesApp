using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServicesApp.Core.Entities
{
    public class Subcategory : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
