using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopAsp.Models.DomainModel.Interfaces;

namespace WorkshopAsp.Models.DomainModel.Repositories
{
    public class CarRepository : ICarRepository
    {
        private WorkshopContext context;
        public CarRepository(WorkshopContext context)
        {
            this.context = context;
        }

        public IQueryable<Car> Cars => context.Cars;

        public void Save(Car car)
        {
            var changedCar = context.Cars.FirstOrDefault(c => c.Id == car.Id);
            if (changedCar != null)
            {
                changedCar.Model = car.Model;
                changedCar.Mark = car.Mark;
                changedCar.Registration = car.Registration;
            }
            else
            {
                context.Cars.Add(car);
            }
            context.SaveChanges();
        }

        public void Delete(int carId)
        {
            var deletedCar = context.Cars.FirstOrDefault(c => c.Id == carId);
            if(deletedCar != null)
            {
                context.Cars.Remove(deletedCar);
                context.SaveChanges();
            }
        }
    }
}
