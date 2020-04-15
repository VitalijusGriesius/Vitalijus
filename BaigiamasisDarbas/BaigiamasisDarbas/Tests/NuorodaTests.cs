using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class NuorodaTests : BaseTests
    {
        private IWebElement NuorodaBitcoin => driver.FindElement(By.LinkText("Bitcoin"));
        private IWebElement Pavadinimas => driver.FindElement(By.CssSelector(".entry-title"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/brokeriai/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]

        public void ArGeraNuoroda()
        {
            string tekstas = "Bitkoinai – ką žinome apie kriptovaliutą";
            NuorodaBitcoin.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.AreEqual(tekstas, Pavadinimas.Text);
        }
    }
}
