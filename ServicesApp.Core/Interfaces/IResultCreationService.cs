﻿using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Interfaces
{
    public interface IResultCreationService
    {
        public Result<T> CreateResult<T>(T result);
    }
}