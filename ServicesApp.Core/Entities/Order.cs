using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServicesApp.Core.Entities
{
    public class Order : BaseEntity
    {
        public string Header { get; set; }

        public string Explanation { get; set; }

        [Required]
        public int SubcategoryId { get; set; }

        public int Budjet { get; set; }

        public string UserId { get; set; }

    }

}
