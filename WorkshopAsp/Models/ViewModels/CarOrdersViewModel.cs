using System.Linq;

namespace WorkshopAsp.Models.ViewModels
{
    public class CarOrdersViewModel
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public IQueryable<Order> Orders { get; set; }
    }
}
