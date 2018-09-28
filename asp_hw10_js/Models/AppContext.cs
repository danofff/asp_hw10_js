using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_hw10_js.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Customer>  Customers { get; set; }
    }
}