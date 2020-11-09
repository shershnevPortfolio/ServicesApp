using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServicesApp.Core.Entities;

namespace ServicesApp.Infrastructure.Data
{
        public class ApplicationUserContext : IdentityDbContext<User>
        {
            public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }

}
