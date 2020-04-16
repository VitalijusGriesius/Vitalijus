using BaigiamasisDarbas.Page;
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

        private SearchFieldPage searchFieldPage;


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            searchFieldPage = new SearchFieldPage(driver);
        }

        [Test]
        public void TestSearchBadValue()
        {
            string badValue = "*";
            string NotFind = "Nepavyko rasti";

            searchFieldPage.EnterBadValue(badValue);

            searchFieldPage.AssertSearchBadValue(NotFind);
        }

        [Test]
        public void TestSearchGoodValue()
        {
            string searchText = "EUR/USD"; // Rasyti didziosiomis raidemis
            string result = "PAIEŠKOS REZULTATAI: EUR/USD";

            searchFieldPage.EnterGoodValue(searchText);

            searchFieldPage.AssertSearchGoodValue(result);

        }
    }
}
