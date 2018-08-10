using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BcseTestTask.Models
{
    public class Bidder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("Seller")]
        public virtual ICollection<Deal> BuyingDeals { get; set; }
        [InverseProperty("Buyer")]
        public virtual ICollection<Deal> SellingDeals { get; set; }
    }
}