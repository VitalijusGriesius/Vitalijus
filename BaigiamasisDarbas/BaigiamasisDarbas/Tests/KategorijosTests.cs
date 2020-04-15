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
        private IWebElement KategorijosIndikatoriai => driver.FindElement(By.LinkText("Forex indikatoriai"));
        private IWebElement ForexIndikatoriuPuslapis => driver.FindElement(By.CssSelector("div#content h1"));
        private IWebElement PradziaButton => driver.FindElement(By.LinkText("Pradžia"));


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]

        public void KategorijosForexStrategijos()
        {
            string tekstas = "KATEGORIJOS ARCHYVAS: FOREX INDIKATORIAI";

            KategorijosIndikatoriai.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(50)).
                Until(d => ForexIndikatoriuPuslapis.Text == "KATEGORIJOS ARCHYVAS: FOREX INDIKATORIAI");

            Assert.AreEqual(tekstas, ForexIndikatoriuPuslapis.Text);

            PradziaButton.Click();

            String URL = driver.Url;
            Assert.AreEqual(URL, "http://spekuliantas.com/");
        }
    }
}
