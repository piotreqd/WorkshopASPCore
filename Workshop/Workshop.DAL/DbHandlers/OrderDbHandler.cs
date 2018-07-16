using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models.Entities;

namespace Workshop.DAL.DbHandlers
{
    public class OrderController
    {
        public void BeginOrder(int carId, string orderName)
        {
            using (var context = new WorkshopContext())
            {
                var order = new Order()
                {
                    CarId = carId,
                    Name = orderName,
                    StartDate = DateTime.Now,
                    EndDate = null
                };
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        public void EndOrder(int orderId)
        {
            using (var context = new WorkshopContext())
            {
                try
                {
                    var order = context.Orders.Find(orderId);
                    order.EndDate = DateTime.Now;
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
