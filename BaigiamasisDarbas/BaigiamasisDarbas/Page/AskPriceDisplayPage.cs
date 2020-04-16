using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class AskPriceDisplayPage : BasePage
    {
        private IWebElement AskPricePricet => driver.FindElement(By.Id("pricet"));
        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private SelectElement DepozitoValiutaSelectElement => new SelectElement(DepozitoValiuta);
        private IWebElement ValiutuPora => driver.FindElement(By.Id("pair"));
        private SelectElement ValiutuPoraSelectElement => new SelectElement(ValiutuPora);

        public AskPriceDisplayPage(IWebDriver driver) : base(driver) { }

        public AskPriceDisplayPage SelectCurrencyAndPair()
        {
            DepozitoValiutaSelectElement.SelectByIndex(3);
            ValiutuPoraSelectElement.SelectByIndex(3);
            return this;
        }

        public AskPriceDisplayPage AssertIsAskPriseDisplayed(string text1, string text2)
        {
            if (AskPricePricet.GetAttribute("style") == text1)
            {
                Assert.True(AskPricePricet.Displayed);
            }
            else if (AskPricePricet.GetAttribute("style") == text2)
            {
                Assert.False(AskPricePricet.Displayed);
            }
            return this;
        }
    }

}
