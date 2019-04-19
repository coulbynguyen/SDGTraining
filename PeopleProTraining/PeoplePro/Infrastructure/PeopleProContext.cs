using Microsoft.EntityFrameworkCore;
using PeoplePro.Interfaces;
using PeoplePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeoplePro.Infrastructure
{
    public class PeopleProContext : DbContext, IPeopleProContext
    {
        public PeopleProContext(DbContextOptions<PeopleProContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
