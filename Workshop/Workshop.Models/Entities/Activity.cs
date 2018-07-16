using System.Collections.Generic;
using WorkshopModels.Entities.Base;

namespace Workshop.Models.Entities
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
