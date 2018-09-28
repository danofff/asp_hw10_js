using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_hw10_js.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }

        public int EmploymentId { get; set; }
        public virtual Employment Employment { get; set; }     

    }
}