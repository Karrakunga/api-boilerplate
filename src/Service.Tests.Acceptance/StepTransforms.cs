using System.Collections.Generic;
using Service.Tests.Acceptance.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Service.Tests.Acceptance
{
    [Binding]
    public class StepTransforms
    {
        [StepArgumentTransformation]
        public IEnumerable<CarModel> TableToCarTransform(Table table)
        {
            return table.CreateSet<CarModel>();
        }
    }
}
