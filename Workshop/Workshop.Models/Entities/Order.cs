using System;
using System.Collections.Generic;
using System.Text;
using WorkshopModels.Entities.Base;

namespace Workshop.Models.Entities
{
    public class Order : BaseEntity
    { 
        public int CarId { get; set; }
        public int Car { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
