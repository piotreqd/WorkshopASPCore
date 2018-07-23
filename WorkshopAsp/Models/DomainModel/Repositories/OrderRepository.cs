using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel.Interfaces;

namespace WorkshopAsp.Models.DomainModel.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private WorkshopContext context;

        public OrderRepository(WorkshopContext context)
        {
            this.context = context;
        }

        public IQueryable<Order> Orders => context.Orders;

        public void Begin()
        {
            throw new NotImplementedException();
        }

        public void End(int orderId)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            order.EndDate = DateTime.Now;
            context.SaveChanges();
        }
    }
}
