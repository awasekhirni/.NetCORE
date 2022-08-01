using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.context
{
    public class ProductContext:DbContext
    {
       public  DbSet<Product> Products {get;set;}
        public DbSet<ProductReview> ProductReviews{get;set;}

    }
}