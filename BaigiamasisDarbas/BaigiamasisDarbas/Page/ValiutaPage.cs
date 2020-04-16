using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class ValiutaPage : BasePage
    {

        private IWebElement Valiuta => driver.FindElement(By.Id("currency"));
        private SelectElement ValiutaSelectElement => new SelectElement(Valiuta);
        private IWebElement SwapRiskMoneyButton => driver.FindElement(By.Id("swapriskmoney"));
        private IWebElement ValiutaDisplayed => driver.FindElement(By.Id("moneyt2"));

        public ValiutaPage(IWebDriver driver) : base(driver) { }


        public ValiutaPage RiskMoneyButton()
        {
            SwapRiskMoneyButton.Click();
            return this;
        }
        public ValiutaPage SelectValiuta()
        {
            ValiutaSelectElement.SelectByIndex(3);
            return this;
        }

        public ValiutaPage AssertSelectValiuta(string text)
        {
            Assert.AreEqual(text, ValiutaDisplayed.Text);
            return this;
        }
    }
}
