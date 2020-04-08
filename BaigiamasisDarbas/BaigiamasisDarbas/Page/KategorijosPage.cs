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

        private IWebElement Kategorijos => driver.FindElement(By.CssSelector(".widget-title"));
        private SelectElement KategorijosSelectElement => new SelectElement(Kategorijos);
        private IWebElement ForexTestaiPuslapis => driver.FindElement(By.CssSelector(".cat-item cat-item-191 current-cat"));
        private IWebElement ForexPradziaPuslapis => driver.FindElement(By.Id("menu-item-9198"));
        private IWebElement PradziaButton => driver.FindElement(By.Id("menu-item-9198"));


        public KategorijosPage SelectForexTestai()
        {
            KategorijosSelectElement.SelectByIndex(6);
            return this;
        }

        public KategorijosPage AssertCorrectPageTestai()
        {
            Assert.AreEqual("http://spekuliantas.com/category/testai/", ForexTestaiPuslapis);
            return this;
        }

        public KategorijosPage ClickPradziaButton()
        {
            PradziaButton.Click();
            return this;
        }
        public KategorijosPage AssertCorrectPagePradzia()
        {
            Assert.AreEqual("http://spekuliantas.com/", ForexTestaiPuslapis);
            return this;
        }

    }
}
