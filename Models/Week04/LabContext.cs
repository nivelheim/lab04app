using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week04Lab.Models.Week04
{
    public class LabContext : DbContext
    {
        public LabContext() : base("DefaultConnection")
        {
 
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}