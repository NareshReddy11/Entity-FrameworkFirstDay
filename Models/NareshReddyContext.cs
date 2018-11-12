using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFramework2.Models
{
    public class NareshReddyContext :DbContext
    {
        public NareshReddyContext ():base("name=NareshReddyConnection")
        {

        }
        public DbSet<Catagiry> CatagiriesTable { get; set; }
        public DbSet<Product> productsTable { get; set; }
    }
}