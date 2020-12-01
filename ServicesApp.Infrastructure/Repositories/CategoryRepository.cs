﻿using Microsoft.EntityFrameworkCore;
using ServicesApp.Core.Abstractions.Interfaces;
using ServicesApp.Core.Entities;
using ServicesApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Infrastructure.Repositories
{
    class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Subcategory>> GetSubcategories(int id)
        {
            var category = await GetById(id);  
            return category.SubCategories;
        }
    }
}
