using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DealersTrack.Models
{
    public class Lendor
    {
        [Key]
        public int lendorId { get; set; }

        public string lendorName { get; set; }

        public string lendorAddress { get; set; }

        // foreign  key 
        public int dealerId { get; set; }

        //Navigation property 
        public Dealer Dealer { get; set; }

    }
}