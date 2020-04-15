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
        private IWebElement AskPricePricet => driver.FindElement(By.Id("pricet"));
        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private IWebElement ValiutuPora => driver.FindElement(By.Id("pair"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [Test]
        public void IsAskPriceDisplayed()
        {
            string none = " none;";
            string block = " block;";

            new SelectElement(DepozitoValiuta).SelectByIndex(3);
            new SelectElement(ValiutuPora).SelectByIndex(3);

            if (AskPricePricet.GetAttribute("style") == block)
            {
                Assert.True(AskPricePricet.Displayed);
            }
            else if (AskPricePricet.GetAttribute("style") == none)
            {
                Assert.False(AskPricePricet.Displayed);
            }
        }
    }
}
