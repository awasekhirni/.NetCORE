using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DealersTrack.Models
{
    public class State
    {
        [Key]
        public int stateId { get; set; }

        public string stateName { get; set; }

        public string stateRegion { get; set; }
    }
}