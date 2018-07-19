using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models
{
    public class Part : BaseEntity
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
