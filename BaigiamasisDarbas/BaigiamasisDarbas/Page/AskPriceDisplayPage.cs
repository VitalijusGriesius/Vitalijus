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
        public AskPriceDisplayPage(IWebDriver driver) : base(driver) { }

        private IWebElement AskPricePricet => driver.FindElement(By.Id("pricet"));
        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private SelectElement DepozitoValiutaSelectElement => new SelectElement(DepozitoValiuta);
        private IWebElement ValiutuPora => driver.FindElement(By.Id("pair"));
        private SelectElement ValiutuPoraSelectElement => new SelectElement(ValiutuPora);

        public AskPriceDisplayPage SelectDepozitoValiutaAndValiutuPora()
        {
            DepozitoValiutaSelectElement.SelectByIndex(3);
            ValiutuPoraSelectElement.SelectByIndex(3);
            return this;
        }

        public AskPriceDisplayPage AssertIsAskPriseDisplayed(string text)
        {
            if (AskPricePricet.GetAttribute("style") == text)
            {
                Assert.True(AskPricePricet.Displayed);
            }
            else if (AskPricePricet.GetAttribute("style") == text)
            {
                Assert.False(AskPricePricet.Displayed);
            }
            return this;
        }
    }

}
