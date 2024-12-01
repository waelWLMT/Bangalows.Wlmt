using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// The my db context.
    /// </summary>
    public class MyDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Bangalow> Bangalows { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comodite> Comodite { get; set; }
        public DbSet<BangalowComercial> BangalowComercials { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ComoditeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new BangalowComercialConfiguration());
            
        }


    }
}
