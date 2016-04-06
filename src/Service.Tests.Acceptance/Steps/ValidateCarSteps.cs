using System;
using System.Collections.Generic;
using api.boilerplate.Database;
using Service.Tests.Acceptance.Models;
using TechTalk.SpecFlow;
using api.boilerplate.Domain;
using NUnit.Framework;


namespace Service.Tests.Acceptance.Steps
{
    [Binding]
    [Scope(Feature = "ValidateCar")]
    public class ValidateCarSteps
    {
        private Guid _carId;

        [Given(@"the following car data")]
        public void GivenTheFollowingCarData(IEnumerable<CarModel> cars)
        {
            foreach (var car in cars)
            {
                car.CarId = Guid.NewGuid();

                Data.CarData.Add(new CarDomain
                {
                    CarId = car.CarId,
                    CarType = car.CarType,
                    Registration = car.Registration,
                    YearBought = car.YearBought
                    
                });

                _carId = car.CarId;
                ScenarioContext.Current.Add("CarGuid", _carId);
            }
        }
        
        [Then(@"our data list should contain (.*) car")]
        public void ThenOurDataListShouldContainCar(int carCount)
        {
            Assert.That(Data.CarData.Count, Is.EqualTo(carCount));
        }



    }
}
