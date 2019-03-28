using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebTest
{
    public class ResultPage : GoogleMainPage
    {
        private IWebElement ResultStatsLabel => Driver.FindElement(By.Id("resultStats"));

        public ResultPage(IWebDriver Driver) : base(Driver)
        {
        }

        public bool AreResultsLoaded()
        {
            return ResultStatsLabel.Displayed;
        }
    }
}
