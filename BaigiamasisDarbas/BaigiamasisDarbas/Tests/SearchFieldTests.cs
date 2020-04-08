using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class SearchFieldTests : BaseTests
    {
        private IWebElement searchField => driver.FindElement(By.Id("s"));
        private IWebElement searchResultGera => driver.FindElement(By.CssSelector(".page-title"));
        private IWebElement searchResulBloga => driver.FindElement(By.CssSelector(".entry-title"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void TestSearchBlogaReiksme()
        {
            searchField.Click();
            searchField.SendKeys("*");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            builder.Build().Perform();

            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).
                Until(d => searchResulBloga.Text == "Nepavyko rasti");

            Assert.AreEqual("Nepavyko rasti", searchResulBloga.Text);
        }

        [Test]
        public void TestSearchGeraReiksme()
        {
            searchField.Click();
            searchField.SendKeys("eur/usd");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            builder.Build().Perform();

            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).
                Until(d => searchResultGera.Text == "PAIEŠKOS REZULTATAI: EUR/USD");

            Assert.AreEqual("PAIEŠKOS REZULTATAI: EUR/USD", searchResultGera.Text);
        }
    }
}
