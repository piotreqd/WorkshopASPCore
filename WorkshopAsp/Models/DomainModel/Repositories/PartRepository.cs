using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel.Interfaces;

namespace WorkshopAsp.Models.DomainModel.Repositories
{
    public class PartRepository : IPartRepository
    {
        private WorkshopContext context;
        public PartRepository(WorkshopContext context)
        {
            this.context = context;
        }

        public IQueryable<Part> Parts => context.Parts;


        public void Save(Part part)
        {
            var changedPart = context.Parts.FirstOrDefault(p => p.Id == part.Id);
            if (changedPart == null)
            {
                context.Parts.Add(part);
            }
            else
            {
                throw new NotImplementedException();
            }
            context.SaveChanges();

        }
    }
}
