using System;
using System.Collections.Generic;

namespace api.boilerplate.Domain
{
    public class CarDomain
    {
        public Guid CarId { get; set; }

        public CarType CarType { get; set; }

        public string Registration { get; set; }

        public int YearBought { get; set; }
    }
}
