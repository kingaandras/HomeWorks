using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Sportman.Tests.Unit.Steps
{
    [Binding]
    public class SportmanSteps
    {
        private Sportman[] sportmanArray;
        private int index;

        private readonly string[] categoryArray = {"amateur", "professional", "classic"};

        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>()
            { {"amatőr", "amateur"}, {"profi", "professional"}, {"klasszis", "classic"} };

        [BeforeScenario()]
        public void Init()
        {
            index = -1;
            sportmanArray = new Sportman[10];
            Sportman.WorldRecord = 0;
        }

        [Given(@"a sportman with name (.*)")]
        public void GivenASportman(string name)
        {
            index++;
            sportmanArray[index] = new Sportman(name);
        }

        [When(@"I add result (\d+) to sportman (.*)")]
        public void WhenIAddResultToSportman(int result, string name)
        {
            var i = 0;

            while (i <= index)
            {
                if (sportmanArray[i].Name == name)
                {
                    sportmanArray[i].NewResult(result);
                    break;
                }              

                i++;
            }
        }

        [When(@"World Record is (.*)")]
        public void WhenWorldRecordIs(int receivedWorldRecord)
        {
            if (index > 0)
            {
                throw new Exception("Too many sportmen defined");
            }

            Sportman.WorldRecord = receivedWorldRecord;
        }

        [When(@"Personal Best is (.*)")]
        public void WhenPersonalBestIs(int receivedPersonalBest)
        {
            if (index > 0)
            {
                throw new Exception("Too many sportmen defined");
            }
            sportmanArray[index].NewResult(receivedPersonalBest);

        }

        [Then(@"the category is (.*)")]
        public void ThenTheCategoryIs(string receivedCategory)
        {
            if (index > 0)
            {
                throw new Exception("Too many sportmen defined");
            }

            if (categoryArray.All(cat => cat != receivedCategory))
            {
                throw new Exception("Invalid category defined");
            }

            var actualCategory = sportmanArray[index].PersonalCategory;

            Assert.AreEqual(receivedCategory, dictionary[actualCategory]);
        }

        [Then(@"the personal best is (\d+) for (.*)")]
        public void ThenThePersonalBestIs(int personalBest, string name)
        {
            var i = 0;
            var pass = true;

            while (i <= index)
            {
                if ((sportmanArray[i].Name == name) && (sportmanArray[i].BestPersonalResult != personalBest))
                {
                    pass = false;
                    break;
                }

                i++;
            }

            Assert.IsTrue(pass);
        }

        [Then(@"the world record is (\d+)")]
        public void ThenTheWorldRecordIs(int worldRecord)
        {   
            Assert.AreEqual(Sportman.WorldRecord, worldRecord);
        }

        [Then(@"the world record is owned by (.*)")]
        public void ThenTheWorldRecordIsOwnedBy(string name)
        {
            Assert.AreEqual(Sportman.WorldRecorder, name);
        }      
    }
}
