using Microsoft.EntityFrameworkCore;
using Principal.We_Watch.Data.Models;
using Principal.We_Watch.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.We_Watch.Data.DbContexts
{
    public class WeWatchDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Evidence> Evidences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(b =>
            //{
            //    b.HasKey(e => e.Id);
            //    b.Property(e => e.Id).ValueGeneratedOnAdd();
            //});

            //modelBuilder.Entity<Incident>(b =>
            //{
            //    b.HasKey(e => e.Id);
            //    b.Property(e => e.Id).ValueGeneratedOnAdd();
            //});

            //modelBuilder.Entity<Evidence>(b =>
            //{
            //    b.HasKey(e => e.Id);
            //    b.Property(e => e.Id).ValueGeneratedOnAdd();
            //});
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=WeWatchDb;Integrated Security=True");
        }
    }
}
