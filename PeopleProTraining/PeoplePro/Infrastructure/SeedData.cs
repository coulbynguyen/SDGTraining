using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PeoplePro.Infrastructure
{
    public class SeedData
    {
        public static void InitializeBuildings(IServiceProvider serviceProvider)
        {
            using (var context = new PeopleProContext(serviceProvider.GetRequiredService<DbContextOptions<PeopleProContext>>()))
            {
                if (context.Buildings.Any())
                {
                    return;
                }
                context.Buildings.AddRange(
                    new Models.Building
                    {
                        BuildingName = "Kelley Engineering Center",
                        BuildingAbrev = "KEC"
                    },
                    new Models.Building
                    {
                        BuildingName = "Milne Computer Center",
                        BuildingAbrev = "MCC"
                    },
                    new Models.Building
                    {
                        BuildingName = "Milam Hall",
                        BuildingAbrev = "MLM"
                    }
                );
                context.SaveChanges();
            }

        }
        public static void InitializeDepartments(IServiceProvider serviceProvider)
        {
            using(var context = new PeopleProContext(serviceProvider.GetRequiredService<DbContextOptions<PeopleProContext>>()))
            {
                if (context.Departments.Any())
                {
                    return;
                }
                context.Departments.AddRange(
                    new Models.Department
                    {
                        DepartmentName = "EECS",
                        DateFounded = new DateTime(2000, 09, 01),
                        BuildingId = context.Buildings.Skip(0).FirstOrDefault().Id
                    },
                    new Models.Department
                    {
                        DepartmentName = "Robotics",
                        DateFounded = new DateTime(2006, 09, 01),
                        BuildingId = context.Buildings.Skip(0).FirstOrDefault().Id
                    }
                );
                context.SaveChanges();
            }
        }
        public static void InitializeEmployees(IServiceProvider serviceProvider)
        {
            using (var context = new PeopleProContext(serviceProvider.GetRequiredService<DbContextOptions<PeopleProContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;
                }
                context.Employees.AddRange(
                    new Models.Employee
                    {
                        FirstName = "Coulby",
                        LastName = "Nguyen",
                        BirthDate = new DateTime(1998, 01, 19),
                        StartDate = new DateTime(2019, 04, 01),
                        DepartmentID = context.Departments.Skip(0).FirstOrDefault().Id
                    },
                    new Models.Employee
                    {
                        FirstName = "Connor",
                        LastName = "Suderman",
                        BirthDate = new DateTime(1998, 08, 28),
                        StartDate = new DateTime(2018, 09, 01),
                        DepartmentID = context.Departments.Skip(0).FirstOrDefault().Id
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
