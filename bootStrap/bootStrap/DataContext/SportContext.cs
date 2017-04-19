using bootStrap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace bootStrap.DataContext
{
    public class SportContext :DbContext
    {
        public SportContext():base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Teams> Teams { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Games> Games { get; set; }

    }
}