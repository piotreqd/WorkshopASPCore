﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopAsp.Models.DomainModel.Interfaces
{
    public interface ICarRepository
    {
        IQueryable<Car> Cars { get; }
        void Save(Car car);
        void Delete(int carId);
    }
}
