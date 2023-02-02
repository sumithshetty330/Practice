using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.EntityFramework;
using WepCRUDOperation.Models;

namespace WepAPIApplication.Models
{
    public class BrandContext:DbContext
    {
        public BrandContext(DbContextOptions<BrandContext>options):base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
    }
}