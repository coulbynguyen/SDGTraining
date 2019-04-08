using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PeoplePro.Models
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext (DbContextOptions<DepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<PeoplePro.Models.Department> Department { get; set; }
    }
}
