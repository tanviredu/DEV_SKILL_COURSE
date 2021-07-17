using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WIREDBRAINCOFFIE_STORAGE.Entities;

namespace WIREDBRAINCOFFIE_STORAGE.Data
{
    public class StorageAppDBContext:DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Organisation> Organisations => Set<Organisation>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }


    }
}
