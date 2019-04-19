using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using PeoplePro.Infrastructure;
using PeoplePro.Models;
using Microsoft.EntityFrameworkCore;

namespace PeoplePro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<PeopleProContext>();
                    context.Database.Migrate();
                    SeedData.InitializeBuildings(services);
             
                }
                catch(Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error Occurred Seeding the DB.");
                }

                try
                {
                    var context = services.GetRequiredService<PeopleProContext>();
                    context.Database.Migrate();
                    SeedData.InitializeDepartments(services);
              
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();

                    logger.LogError(ex, "An Error Occured Seeding the DB.");
                }
                try
                {
                    var context = services.GetRequiredService<PeopleProContext>();
                    context.Database.Migrate();
                    SeedData.InitializeEmployees(services);
         
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error Occured Seeding the DB.");
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
