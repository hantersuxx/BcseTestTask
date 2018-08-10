using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BcseTestTask.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public virtual Tool Tool { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public DateTime Date { get; set; }
        public virtual Bidder Seller { get; set; }
        public virtual Bidder Buyer { get; set; }
    }
}