﻿
using System.Collections.Generic;
using WorkshopModels.Entities.Base;

namespace Warsztat.Model
{
    public class Car : BaseEntity
    { 
        public int OwnerId { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public string Registration { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
    }
}
