using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Owindows.models
{
    public class InsuranceModel
    {
        public int policyId { get; set; }
        public string policyName { get; set; }
        public string policyType { get; set; }

        public double premiumAmount { get; set; }

        public double insuredAmount { get; set; }

        public bool isActive { get; set; }
    }
}