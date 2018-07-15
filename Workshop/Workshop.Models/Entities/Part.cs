using System;
using System.Collections.Generic;
using System.Text;
using WorkshopModels.Entities.Base;

namespace Warsztat.Model
{
    public class Part : BaseEntity
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
