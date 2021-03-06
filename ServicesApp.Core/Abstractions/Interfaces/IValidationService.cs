﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesApp.Core.Abstractions.Interfaces
{
    internal interface IValidationService
    {
        void ValidateQueryResult<T>(T result);

        void ValidateQuery<T>(T Query);

    }
}
