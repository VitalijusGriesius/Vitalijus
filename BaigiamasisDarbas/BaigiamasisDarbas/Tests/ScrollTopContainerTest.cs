using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class ScrollTopContainerTest : BaseTests
    {
        private IWebElement ScrollTopContainer => driver.FindElement(By.Id("wpfront-scroll-top-container"));
        
        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void CheckScrollTopButton()
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.PageDown);
            builder.Build().Perform();

            Assert.IsTrue(ScrollTopContainer.Displayed);
        }
    }
}
