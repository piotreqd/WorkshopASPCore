using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel;

namespace WorkshopAsp.Models
{
    public class OwnerRepository : IOwnerRepository
    {
        private WorkshopContext context;
        public OwnerRepository(WorkshopContext context)
        {
            this.context = context;
        }
        public IQueryable<Owner> Owners => context.Owners;
        public void Save(Owner owner)
        {
            var changedOwner = context.Owners.FirstOrDefault(o => o.Id == owner.Id);
            if(changedOwner != null)
            {
                changedOwner.PhoneNumber = owner.PhoneNumber;
            }
            context.SaveChanges();
        }
    }
}
