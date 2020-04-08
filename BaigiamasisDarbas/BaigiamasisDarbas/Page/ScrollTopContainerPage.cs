using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class ScrollTopContainerPage : BasePage
    {
        private IWebElement ScrollTopContainer => driver.FindElement(By.Id("wpfront-scroll-top-container"));
        public ScrollTopContainerPage(IWebDriver driver) : base(driver) { }

        public ScrollTopContainerPage PageDown()
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.PageDown);
            builder.Build().Perform();
            return this;
        }
        public ScrollTopContainerPage ScrollTop()
        {
            ScrollTopContainer.Click();
            return this;
        }

        public ScrollTopContainerPage AssertScrollTop()
        {
            Assert.IsTrue(ScrollTopContainer.Displayed);
            return this;
        }
    }
}

 
