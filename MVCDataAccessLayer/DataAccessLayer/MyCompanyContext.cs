using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using MVCDataAccessLayer.Models;

namespace MVCDataAccessLayer.DataAccessLayer
{
    public class MyCompanyContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("MyEmployee");
            base.OnModelCreating(modelBuilder);
        }
        //DbSet will represent all the employees that can be queried from the database

        public DbSet<Employee> Employees { get; set; }
    }
}