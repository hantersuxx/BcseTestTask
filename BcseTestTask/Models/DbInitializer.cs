using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BcseTestTask.Models
{
    public class DbInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            Tool tool1 = new Tool { Name = "USD" };
            Tool tool2 = new Tool { Name = "RUB" };
            Tool tool3 = new Tool { Name = "EUR" };

            var defaultTools = new List<Tool> { tool1, tool2, tool3 };
            context.Tools.AddRange(defaultTools);
            context.SaveChanges();

            Bidder bidder1 = new Bidder { Name = nameof(bidder1) };
            Bidder bidder2 = new Bidder { Name = nameof(bidder2) };
            Bidder bidder3 = new Bidder { Name = nameof(bidder3) };
            Bidder bidder4 = new Bidder { Name = nameof(bidder4) };

            var defaultBidders = new List<Bidder> { bidder1, bidder2, bidder3, bidder4 };
            context.Bidders.AddRange(defaultBidders);
            context.SaveChanges();

            Deal deal1 = new Deal { Tool = tool1, Price = 1000m, Volume = 1000m, Date = new DateTime(2018, 08, 01), Buyer = bidder1, Seller = bidder2 };
            Deal deal2 = new Deal { Tool = tool1, Price = 990.64m, Volume = 1000m, Date = new DateTime(2018, 08, 02), Buyer = bidder2, Seller = bidder3 };
            Deal deal3 = new Deal { Tool = tool1, Price = 920.36m, Volume = 1000m, Date = new DateTime(2018, 08, 03), Buyer = bidder3, Seller = bidder4 };
            Deal deal4 = new Deal { Tool = tool1, Price = 1000.25m, Volume = 1000m, Date = new DateTime(2018, 08, 04), Buyer = bidder4, Seller = bidder1 };
            Deal deal5 = new Deal { Tool = tool1, Price = 1000m, Volume = 1000m, Date = new DateTime(2018, 08, 05), Buyer = bidder1, Seller = bidder2 };
            Deal deal6 = new Deal { Tool = tool1, Price = 840.04m, Volume = 1000m, Date = new DateTime(2018, 08, 06), Buyer = bidder2, Seller = bidder3 };
            Deal deal7 = new Deal { Tool = tool1, Price = 950.77m, Volume = 1000m, Date = new DateTime(2018, 08, 07), Buyer = bidder3, Seller = bidder4 };

            var defaultDeals = new List<Deal> { deal1, deal2, deal3, deal4, deal5, deal6, deal7 };
            context.Deals.AddRange(defaultDeals);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}