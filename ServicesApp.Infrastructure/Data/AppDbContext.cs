﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServicesApp.Core.Entities;

namespace ServicesApp.Infrastructure.Data
{
        public class ApplicationContext : IdentityDbContext<User>
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }

            public virtual DbSet<Category> Categories { get; set; }
            public virtual DbSet<SubCategory> SubCategories { get; set; }
    }


}
