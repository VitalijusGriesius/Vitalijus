using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
   public class KategorijosPage : BasePage
    {
        public KategorijosPage(IWebDriver driver) : base(driver) { }

        private IWebElement KategorijosIndikatoriai => driver.FindElement(By.LinkText("Forex indikatoriai"));
        private IWebElement ForexIndikatoriuPuslapis => driver.FindElement(By.CssSelector("div#content h1"));
        private IWebElement PradziaButton => driver.FindElement(By.LinkText("Pradžia"));


        public KategorijosPage SelectForexIndikatoriai()
        {
            KategorijosIndikatoriai.Click();
            return this;
        }

        public KategorijosPage AssertCorrectPageIndikatoriai(string text)
        {
            Assert.AreEqual(text, ForexIndikatoriuPuslapis);
            return this;
        }

        public KategorijosPage ClickPradziaButton()
        {
            PradziaButton.Click();
            return this;
        }
        public KategorijosPage AssertCorrectPagePradzia(string URL)
        {
            Assert.AreEqual(URL, PradziaButton);
            return this;
        }

    }
}
