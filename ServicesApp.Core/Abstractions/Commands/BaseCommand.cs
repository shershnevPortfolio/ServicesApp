﻿using Ardalis.Result;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Queries
{
    public abstract class BaseCommand
    {
        public Result<object> Result  { get; set; }

    }
}
