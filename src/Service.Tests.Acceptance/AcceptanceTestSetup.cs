using TechTalk.SpecFlow;

namespace Service.Tests.Acceptance
{
    [Binding]
    public class AcceptanceTestSetup
    {
        [BeforeFeature()]
        public static void TearDownDatabase()
        {
            
        }
    }
}
