using bootStrap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bootStrap.DataContext
{
    public class SportContext :DbContext
    {
        public SportContext():base()
        {

        }

        public DbSet<Teams> Teams { get; set; }
    }
}