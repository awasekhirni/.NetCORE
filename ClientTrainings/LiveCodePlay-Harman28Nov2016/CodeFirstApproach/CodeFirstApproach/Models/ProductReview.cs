using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstApproach.Models
{
    public class ProductReview
    {
        [Key]
        public int prodReviewId { get; set; }
        public string prodReviewDesc { get; set; }
        public int prodRating { get; set; }

        //foreign key 
        public int prodId { get; set; }

        //navigation property
        public Product product { get; set; }

    }
}