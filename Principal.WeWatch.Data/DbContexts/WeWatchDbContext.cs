using Microsoft.EntityFrameworkCore;
using Principal.WeWatch.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principal.We_Watch.Data.DbContexts
{
    public class WeWatchDbContext : DbContext
    {
        public DbSet<Evidence> Evidences { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<RejectedRequests> RejectedRequests { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }

        public WeWatchDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
