using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models
{
    public class Activity : BaseEntity
    {
        public int OrderId { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Part> Parts { get; set; }

        public string Name { get; set; }
        public decimal LaborPrice { get; set; }
    }
}
