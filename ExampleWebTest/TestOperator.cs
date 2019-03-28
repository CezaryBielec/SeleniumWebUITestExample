using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ExampleWebTest
{
    public class TestOperator : IDisposable
    {
        protected IWebDriver Driver;

        public TestOperator()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
