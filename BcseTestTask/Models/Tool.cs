using System.Collections.Generic;

namespace BcseTestTask.Models
{
    public class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }
    }
}