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
        private IWebElement DepozitoValiuta => driver.FindElement(By.Id("currency"));
        private SelectElement DepozitoValiutaSelectElement => new SelectElement(DepozitoValiuta);
        private IWebElement ValiutuPora=> driver.FindElement(By.Id("pair"));
        private SelectElement ValiutuPoraSelectElement => new SelectElement(ValiutuPora);
        private IWebElement SwapRiskMoneyButton => driver.FindElement(By.Id("swapriskmoney"));
        private IWebElement DepozitoDydisField => driver.FindElement(By.Id("size"));
        private IWebElement RizikaField => driver.FindElement(By.Id("risk"));
        private IWebElement StopLossField => driver.FindElement(By.Id("stop"));
        private IWebElement AskPriceField => driver.FindElement(By.Id("price"));
        private IWebElement SkaiciuotiButton => driver.FindElement(By.CssSelector("input[value=Skaičiuoti]"));
        private IWebElement RizikosDydis => driver.FindElement(By.Name("money"));

        public SkaiciuoklePage(IWebDriver driver) : base(driver) { }


        public SkaiciuoklePage SelectCurrency()
        {
            DepozitoValiutaSelectElement.SelectByIndex(3);
            return this;
        }
        public SkaiciuoklePage ClickSwapRiskMOneyButton()
        {
            SwapRiskMoneyButton.Click();
            return this;
        }
        public SkaiciuoklePage EnterTextInSizeField(string number)
        {
            DepozitoDydisField.Clear();
            DepozitoDydisField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage EnterTextInRiskField(string number)
        {
            RizikaField.Clear();
            RizikaField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage EnterTextInStopLossField(string number)
        {
            StopLossField.Clear();
            StopLossField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage SelectPair()
        {
            ValiutuPoraSelectElement.SelectByIndex(3);
            return this;
        }
        public SkaiciuoklePage EnterTextInAskPriceField(string number)
        {
            AskPriceField.Clear();
            AskPriceField.SendKeys(number);
            return this;
        }
        public SkaiciuoklePage ClickCalculateRezult()
        {
            SkaiciuotiButton.Click();
            return this;
        }
        public SkaiciuoklePage AssertResult(string text)
        {
            Assert.AreEqual(text, RizikosDydis.GetAttribute("value"));
            return this;
        }

    }

}
