using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class SkaiciuoklePage : BasePage
    {
        public SkaiciuoklePage(IWebDriver driver) : base(driver) { }

        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private SelectElement DepozitoValiutaSelectElement => new SelectElement(DepozitoValiuta);
        private IWebElement ValiutuPora=> driver.FindElement(By.Id("pair"));
        private SelectElement ValiutuPoraSelectElement => new SelectElement(ValiutuPora);
        private IWebElement DepozitoDydisField => driver.FindElement(By.Id("size"));
        private IWebElement RizikaField => driver.FindElement(By.Id("risk"));
        private IWebElement StopLossField => driver.FindElement(By.Id("stop"));
        private IWebElement AskPriceField => driver.FindElement(By.Id("price"));
        private IWebElement SkaiciuotiButton => driver.FindElement(By.CssSelector("input[value=Skaičiuoti]"));
        private IWebElement RizikosDydis => driver.FindElement(By.Name("money"));

        public SkaiciuoklePage SelectDepozitoValiuta()
        {
            DepozitoValiutaSelectElement.SelectByIndex(3);
            return this;
        }
        public SkaiciuoklePage EnterTextInDepozitoDydisField(string number)
        {
            DepozitoDydisField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage EnterTextInRizikaField(string number)
        {
            RizikaField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage EnterTextInStopLossField(string number)
        {
            StopLossField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage SelectValiutuPora()
        {
            ValiutuPoraSelectElement.SelectByIndex(3);
            return this;
        }
        public SkaiciuoklePage EnterTextInAskPriceField(string number)
        {
            AskPriceField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage ClickCalculateRezult()
        {
            SkaiciuotiButton.Click();
            return this;
        }
        public SkaiciuoklePage AssertRezultataiAtitinka(string text)
        {
            Assert.AreEqual(text, RizikosDydis);
            return this;
        }

    }

}
