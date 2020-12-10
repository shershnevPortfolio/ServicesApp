﻿using ServicesApp.Core.Abstractions.Queries;
using ServicesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace ServicesApp.Core.Commands
{
    public class CreateCategoryCommand : CreateCommand<Category>
    {
        public string Name { get; set; }
    }
}
