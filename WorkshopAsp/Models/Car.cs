using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models
{
    public class Car : BaseEntity
    {
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public string Registration { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
    }
}
