using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BcseTestTask.Models
{
    public class Context : DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Bidder> Bidders { get; set; }
        public DbSet<Tool> Tools { get; set; }

        public Context() : base("BcseDB") { }
    }
}