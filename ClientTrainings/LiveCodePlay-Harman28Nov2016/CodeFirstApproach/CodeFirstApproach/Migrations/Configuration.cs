namespace CodeFirstApproach.Migrations
{
    using CodeFirstApproach.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstApproach.context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirstApproach.context.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                            p => p.prodId,
                            new Product
                            {

                                prodId = 12312312,
                                prodName = "Apple iphone 7",
                                prodDesc = "Apple Iphone 7 64GB"
                            },

                            new Product
                            {

                                prodId = 232312,
                                prodName = "Samsung S7",
                                prodDesc = "Samsung S7 64GB"
                            },


                            new Product
                            {

                                prodId = 56452,
                                prodName = "oneplus 3T",
                                prodDesc = "OnePlus Volte"
                            });

            context.ProductReviews.AddOrUpdate(
                p => p.prodReviewId,
                new ProductReview
                {
                    prodReviewId = 7826,
                    prodReviewDesc = " It blows off or heating problem",
                    prodRating = 3,
                    prodId = 232312

                },


                new ProductReview
                {
                    prodReviewId = 2342,
                    prodReviewDesc = " Overpriced, low resolution of camera",
                    prodRating = 4,
                    prodId = 12312312

                },


                new ProductReview
                {
                    prodReviewId = 3232,
                    prodReviewDesc = " Large Screen Size",
                    prodRating = 4,
                    prodId = 56452

                });

        }
    }
}
