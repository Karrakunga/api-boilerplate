using System;
using System.Collections.Generic;
using System.Threading;
using api.boilerplate.Database;
using Service.Tests.Acceptance.Models;
using TechTalk.SpecFlow;
using api.boilerplate.Domain;


namespace Service.Tests.Acceptance.Steps
{
    [Binding]
    public class ValidateCarSteps
    {
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
            }
        }
        
        [When(@"the endpoint is called")]
        public void WhenTheEndpointIsCalled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following data should be returned")]
        public void ThenTheFollowingDataShouldBeReturned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the api will return a response of Ok")]
        public void ThenTheApiWillReturnAResponseOfOk()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
