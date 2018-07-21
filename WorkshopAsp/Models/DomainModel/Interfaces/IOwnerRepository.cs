using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models
{
    public interface IOwnerRepository
    {
        IQueryable<Owner> Owners { get; }
        void Save(Owner owner);
    }
}
