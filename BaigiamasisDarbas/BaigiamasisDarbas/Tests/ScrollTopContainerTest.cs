using BaigiamasisDarbas.Page;
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
        private ScrollTopContainerPage scrollTopContainerPage;

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            scrollTopContainerPage = new ScrollTopContainerPage(driver);
        }

        [Test]
        public void AssertIsScrollTopDisplayed()
        {
            scrollTopContainerPage.PageDown();

            scrollTopContainerPage.AssertIsScrollTop();
        }
    }
}
