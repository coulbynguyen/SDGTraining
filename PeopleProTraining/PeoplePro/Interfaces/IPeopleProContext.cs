using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PeoplePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeoplePro.Interfaces
{
    public interface IPeopleProContext : IDisposable
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Building> Buildings { get; set; }
        DbSet<Department> Departments { get; set; }

        int SaveChanges();
        EntityEntry Entry(object entity);
    }
}
