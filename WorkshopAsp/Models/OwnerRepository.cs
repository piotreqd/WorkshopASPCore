using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
