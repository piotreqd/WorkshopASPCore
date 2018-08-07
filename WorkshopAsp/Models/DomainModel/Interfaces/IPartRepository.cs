using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.DomainModel.Interfaces
{
    public interface IPartRepository
    {
        IQueryable<Part> Parts { get; }
        void Save(Part part);
        void Delete(int partId);
    }
}
