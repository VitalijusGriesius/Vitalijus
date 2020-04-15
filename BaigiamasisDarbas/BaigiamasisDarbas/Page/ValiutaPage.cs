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
        public ValiutaPage(IWebDriver driver) : base(driver) { }

        private IWebElement Valiuta => driver.FindElement(By.Id("currency"));
        private SelectElement ValiutaSelectElement => new SelectElement(Valiuta);
        private IWebElement ValiutaDisplayed => driver.FindElement(By.Id("moneyt2"));


        public ValiutaPage SelectValiuta()
        {
            ValiutaSelectElement.SelectByIndex(3);
            return this;
        }

        public ValiutaPage AssertSelectValiuta()
        {
            Assert.AreEqual("Ppinigai, valiuta", ValiutaDisplayed.Text);
            return this;
        }
    }
}
