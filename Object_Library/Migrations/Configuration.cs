using Object_Library.Context;

namespace Object_Library.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkazatiDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SkazatiDb context)
        {
            context.ContactUses.AddOrUpdate(r => r.Name, new Entity.ContactUs()
                  {
                      Name = Environment.UserName,
                      DateOfSend = DateTime.Now,
                      Email = "admin@skazati.com",
                      Message = "This is a test message.",
                      Subject = "This is a subject"
                  }

           );

            //context.Restaurants.AddOrUpdate(r => r.Name,
            //          new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
            //          new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
            //          new Restaurant
            //          {
            //              Name = "Smaka",
            //              City = "Gothenburg",
            //              Country = "Sweden",
            //              Reviews =
            //                  new List<RestaurantReview> {
            //           new RestaurantReview { Rating = 9, Body="Great food!", ReviewerName="Scott" }
            //              }
            //          });
        }



    }
}
