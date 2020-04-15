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

            searchField.SendKeys(Keys.Enter);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.AreEqual("Nepavyko rasti", searchResulBloga.Text);
        }

        [Test]
        public void TestSearchGeraReiksme()
        {
            string searchText = "EUR/USD"; // Rasyti didziosiomis raidemis
            searchField.Click();
            searchField.SendKeys(searchText);
            
            searchField.SendKeys(Keys.Enter);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.AreEqual($"PAIEŠKOS REZULTATAI: {searchText}", searchResultGera.Text);
        }
    }
}
