using System;
using System.Collections.Generic;
using System.Text;
using WorkshopModels.Entities.Base;

namespace Workshop.Models.Entities
{
    public class Owner : BaseEntity
    {
        public ICollection<Car> Cars { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }
}
