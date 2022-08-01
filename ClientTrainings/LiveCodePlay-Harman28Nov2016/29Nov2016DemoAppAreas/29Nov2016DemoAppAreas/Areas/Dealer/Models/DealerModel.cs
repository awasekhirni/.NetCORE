using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _29Nov2016DemoAppAreas.Areas.Dealer.Models
{
    public class DealerModel
    {
        public int dealerId { get; set; }
        public string legalName { get; set; }
        public string dbaName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string webAddress { get; set; }

        public string Email { get; set; }
    }
}