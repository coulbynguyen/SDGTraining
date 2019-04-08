using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PeoplePro.Models
{
    public class BuildingContext : DbContext
    {
        public BuildingContext (DbContextOptions<BuildingContext> options)
            : base(options)
        {
        }

        public DbSet<PeoplePro.Models.Building> Building { get; set; }
    }
}
