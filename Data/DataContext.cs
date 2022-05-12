#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeCrud.Models;

namespace EmployeeCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
        .Entity<Employee>()
        .HasMany(e => e.PhoneNumbers)
        .WithOne(e => e.Employee)
        .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<EmployeeCrud.Models.Employee> Employee { get; set; }
    }
}
