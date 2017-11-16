using System;
using TechTalk.SpecFlow;

namespace Sportman
{
    [Binding]
    public class SportmanUnitTestsSteps
    {
        [Given(@"a sportman named Teofil")]
        public void GivenASportmanNamedTeofil()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add results to Teofil")]
        public void WhenIAddResultsToTeofil()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the personal best is the highest of results of Teofil")]
        public void ThenThePersonalBestIsTheHighestOfResultsOfTeofil()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
