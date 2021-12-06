using ASP_Final_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GamingPC> GamingPCs { get; set; }
        public DbSet<CustomPC> CustomPCs { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
    }
}
