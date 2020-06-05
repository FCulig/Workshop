using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Radionica.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Vjezba.Model;

namespace Vjezba.DAL
{
    //dotnet ef migrations add Initial --startup-project Vjezba.Web --context WorkshopDbContext --project Vjezba.DAL
    //dotnet ef database update Initial --startup-project Vjezba.Web --context WorkshopDbContext --project Vjezba.DAL
    public class WorkshopDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Breakdown> Breakdowns { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> Cities { get; set; }

        protected WorkshopDbContext() { }

        public WorkshopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    ID = 1,
                    Name = "Zagreb",
                },
                new City
                {
                    ID = 2,
                    Name = "Velika Gorica",
                },
                new City
                {
                    ID = 3,
                    Name = "Sesvete",
                });

            /*modelBuilder.Entity<Employee>().HasData(
                );*/
        }
    }
}
