using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class NuorodaPage : BasePage
    {

        private IWebElement NuorodaBitcoin => driver.FindElement(By.LinkText("Bitcoin"));
        private IWebElement Pavadinimas => driver.FindElement(By.CssSelector(".entry-title"));

        public NuorodaPage(IWebDriver driver) : base(driver) { }

        public NuorodaPage LinkBitcoinClick()
        {
            NuorodaBitcoin.Click();
            return this;
        }
        public NuorodaPage AssertIsCorrectLink(string text)
        {
            Assert.AreEqual(text, Pavadinimas.Text);
            return this;
        }
    }
}
