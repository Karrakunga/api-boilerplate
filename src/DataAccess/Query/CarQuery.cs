﻿using System.Collections.Generic;
using api.boilerplate.Domain;

namespace api.boilerplate.DataAccess
{
    public class CarQuery
    {
        public IEnumerable<CarDomain> GetByType(CarType carType)
        {
            return Database.Data.CarData.FindAll(c => c.CarType == carType);
        }   
    }
}
