using System;
using System.Collections.Generic;
using System.Linq;
using Workshop.Models.Entities;

namespace Workshop.DAL.DbHandlers
{
    public class CarDbHandler
    {
        public void Delete(int carId)
        {
            using (var context = new WorkshopContext())
            {
                try
                {
                    context.Remove(context.Cars.Find(carId));
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        public void Add(int ownerId, string mark, string model, string registration)
        {
            var newCar = new Car()
            {
                OwnerId = ownerId,
                Mark = mark,
                Model = model,
                Registration = registration
            };
            using (var context = new WorkshopContext())
            {
                context.Cars.Add(newCar);
                context.SaveChanges();
            }
        }
        public List<Car> GetCars(int OwnerId)
        {
            using (var context = new WorkshopContext())
            {
                return context.Cars.Where(c => c.OwnerId == OwnerId).ToList();
            }
        }
    }
}
