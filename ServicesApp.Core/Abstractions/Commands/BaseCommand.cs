using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Commands
{
    public abstract class BaseCommand
    {
        public Result<object> Result  { get; set; }

    }
}
