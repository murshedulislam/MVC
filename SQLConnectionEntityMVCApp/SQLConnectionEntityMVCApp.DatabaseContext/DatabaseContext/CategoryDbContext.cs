using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SQLConnectionEntityMVCApp.Models.Models;

namespace SQLConnectionEntityMVCApp.DatabaseContext.DatabaseContext
{
    public class CategoryDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}
