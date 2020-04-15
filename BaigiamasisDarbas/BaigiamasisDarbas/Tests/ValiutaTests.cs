using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class ValiutaTests : BaseTests
    {
        private IWebElement Valiuta => driver.FindElement(By.Id("currency"));
        private IWebElement SwapRiskMoneyButton => driver.FindElement(By.Id("swapriskmoney"));
        private IWebElement ValiutaDisplayed => driver.FindElement(By.Id("moneyt2"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void PasirinktaValiuta()
        {
            SwapRiskMoneyButton.Click();

            new SelectElement(Valiuta).SelectByIndex(3);

            Assert.AreEqual("Pinigai, JPY", ValiutaDisplayed.Text);
        }
    }
}
