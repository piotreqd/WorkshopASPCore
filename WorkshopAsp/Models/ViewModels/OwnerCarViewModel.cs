using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.ViewModels
{
    public class OwnerCarViewModel
    {
        public string OwnerFullName { get; set; }
        public int OwnerId { get; set; }
        public IQueryable<Car> Cars { get; set; }
    }
}
