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
    public class SkaiciuokleTests : BaseTests
    {

        private IWebElement SwapRiskMoneyButton => driver.FindElement(By.Id("swapriskmoney"));
        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private IWebElement ValiutuPora => driver.FindElement(By.Id("pair"));
        private IWebElement DepozitoDydisField => driver.FindElement(By.Id("size"));
        private IWebElement RizikaField => driver.FindElement(By.Id("risk"));
        private IWebElement StopLossField => driver.FindElement(By.Id("stop"));
        private IWebElement AskPriceField => driver.FindElement(By.Id("price"));
        private IWebElement SkaiciuotiButton => driver.FindElement(By.CssSelector("input[value=Skaičiuoti]"));
        private IWebElement RizikosDydis => driver.FindElement(By.Name("money"));
        
        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void SkaiciuoklesRezultatas()
        {
            var depozitoDydis = "1500";
            var RizikaPinigais = "280";
            var StopLoss = "30";
            var AskPrice = "1.3458";
            var RizikosDydisProc = "18.67";

            new SelectElement(DepozitoValiuta).SelectByIndex(2);
            new SelectElement(ValiutuPora).SelectByIndex(1);

            SwapRiskMoneyButton.Click();

            DepozitoDydisField.Clear();
            DepozitoDydisField.SendKeys(depozitoDydis);

            RizikaField.Clear();
            RizikaField.SendKeys(RizikaPinigais);
            
            StopLossField.Clear();
            StopLossField.SendKeys(StopLoss);
            
            AskPriceField.Clear();
            AskPriceField.SendKeys(AskPrice);
            SkaiciuotiButton.Click();

            Assert.AreEqual(RizikosDydisProc,RizikosDydis.GetAttribute("value"));
        }
    }
}
