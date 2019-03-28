using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebTest
{
    public class GoogleMainPage
    {
        protected IWebDriver Driver;
        private IWebElement SearchTextBox => Driver.FindElement(By.Name("q"));
        private IWebElement SearchButton => Driver.FindElement(By.XPath("//div[@class='FPdoLc VlcLAe']//input[@name='btnK']"));

        public GoogleMainPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        public ResultPage SearchForPhrase(string phrase)
        {
            SearchTextBox.SendKeys(phrase);
            SearchButton.Click();
            return new ResultPage(Driver);
        }
    }
}
