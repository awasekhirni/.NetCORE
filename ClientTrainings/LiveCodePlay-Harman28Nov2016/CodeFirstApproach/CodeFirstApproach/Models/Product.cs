using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class Product
    {
        [Key]
        public int prodId { get; set; }
        public string  prodName { get; set; }
        public string prodDesc { get; set; }
    }
}