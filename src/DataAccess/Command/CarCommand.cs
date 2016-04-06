﻿using System;
using api.boilerplate.Domain;

namespace api.boilerplate.DataAccess.Command
{
    public class CarCommand
    {
        public Guid AddToDatabase(CarDomain car)
        {
            car.CarId = Guid.NewGuid();

            Database.Data.CarData.Add(car);

            return car.CarId;
        }
    }
}
