using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyMVCApp.Models.Models;

namespace MyMVCAppDatbaseContect.DatabaseContext
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
