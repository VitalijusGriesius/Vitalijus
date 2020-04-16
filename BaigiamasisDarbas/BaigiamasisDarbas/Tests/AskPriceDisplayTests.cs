using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BaigiamasisDarbas.Tests
{
    public class AskPriceDisplayTests : BaseTests
    {

        private AskPriceDisplayPage askPriceDisplayPage;

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            askPriceDisplayPage = new AskPriceDisplayPage(driver);
        }

        [Test]
        public void IsAskPriceDisplayed()
        {
            string block = " block;";
            string none = " none;";

            askPriceDisplayPage.SelectCurrencyAndPair();

            askPriceDisplayPage.AssertIsAskPriseDisplayed(block, none);

        }
    }
}
