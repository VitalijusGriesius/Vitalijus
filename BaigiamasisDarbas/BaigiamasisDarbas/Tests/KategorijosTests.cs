using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
   public class KategorijosTests : BaseTests
    {
        private IWebElement Kategorijos => driver.FindElement(By.CssSelector(".widget-title"));
        private SelectElement KategorijosSelectElement => new SelectElement(Kategorijos);
        private IWebElement ForexTestaiPuslapis => driver.FindElement(By.CssSelector(".cat-item cat-item-191 current-cat"));
        private IWebElement ForexPradziaPuslapis => driver.FindElement(By.Id("menu-item-9198"));
        private IWebElement PradziaButton => driver.FindElement(By.Id("menu-item-9198"));


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]

        public void KategorijosForexTestai()
        {
            KategorijosSelectElement.SelectByIndex(6);

            Assert.AreEqual("http://spekuliantas.com/category/testai/", ForexTestaiPuslapis);
        }
      
    }
}
