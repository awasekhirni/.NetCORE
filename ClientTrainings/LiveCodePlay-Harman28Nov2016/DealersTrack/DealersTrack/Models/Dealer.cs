using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DealersTrack.Models
{
    public class Dealer
    {
        [Key]
        public int dealerId { get; set; }
        public string dealerName { get; set; }
        public string dealerAddress { get; set; }

        //foreign key
        public int stateId { get; set; }

        //Navigation Property
        public State State { get; set; }
    }
}