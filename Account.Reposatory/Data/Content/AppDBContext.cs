using Account.Core.Models.Account;
using Account.Core.Models.Content;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Account.Reposatory.Data.Content
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedRoles(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Visitor", ConcurrencyStamp = "0", NormalizedName = "Visitor" },
                new IdentityRole { Name = "GovernmentAgency", ConcurrencyStamp = "1", NormalizedName = "GovernmentAgency" },
                new IdentityRole { Name = "CivilSocietyOrganization", ConcurrencyStamp = "2", NormalizedName = "CivilSociety Organization" },
                new IdentityRole { Name = "PrivateSector", ConcurrencyStamp = "3", NormalizedName = "PrivateSector" }
            );
        }


        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<GoverrateAgencyMission> GoverrateAgency { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ComplementModel> Complements { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<AssociationModel> Associations { get; set; }

    }
}