using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _29Nov2016DemoAppAreas.Areas.Customer.Models
{
    public class CustomerModel
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }

        public string province { get; set; }

        public string customerEmpStatus { get; set; }
        public double Salary { get; set; }
        public string salaryType { get; set; }

        public string customerEmployerName { get; set; }

    }
}