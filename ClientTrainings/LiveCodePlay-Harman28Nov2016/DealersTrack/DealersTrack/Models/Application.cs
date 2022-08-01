using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DealersTrack.Models
{
    public class Application
    {
        [Key]
        public int applicationId { get; set; }
        
       

        public string customerName { get; set; }

       //foreign key 
       
        public int dealerId { get; set; }

        
        public Dealer Dealer { get; set; }



    }
}