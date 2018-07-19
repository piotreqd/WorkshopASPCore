using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models
{
    public class FakeProductRepository : IOwnerRepository
    {
        public IQueryable<Owner> Owners => new List<Owner>
        {
            new Owner{Name = "Kakashi", Surname = "Hatake", PhoneNumber = "111222333"},
            new Owner{Name = "Naruto", Surname = "Uzumaki", PhoneNumber = "222333444"},
        }.AsQueryable();
    }
}
