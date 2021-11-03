using HomeManagement.Application.Abstractions;
using HomeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Persistance.EntityFramework
{
    public class HomeManagementDbContext : DbContext, IHomeManagementDbContext
    {

        public HomeManagementDbContext(DbContextOptions<HomeManagementDbContext> options) : base(options)
        {          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("HomeManagement");

            modelBuilder.Entity<Income>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<HomeMember>()
                .HasKey(i => i.Id);
        }

        public DbSet<Income> Incomes { get; set; }

        public DbSet<HomeMember> HomeMembers { get; set; }
    }
}
