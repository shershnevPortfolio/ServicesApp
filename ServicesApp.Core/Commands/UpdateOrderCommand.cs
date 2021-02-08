using ServicesApp.Core.Abstractions.Commands;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Commands
{
    public class UpdateOrderCommand : UpdateCommand<Order>
    {
        public int Budjet { get; set; }

        public string Explanation { get; set; }

        public string Header { get; set; }
    }
}
