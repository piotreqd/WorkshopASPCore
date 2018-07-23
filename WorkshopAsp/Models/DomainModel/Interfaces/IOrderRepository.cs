using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.DomainModel.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void Begin();
        void End(int orderId);
    }
}
