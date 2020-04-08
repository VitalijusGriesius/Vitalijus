﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    public class SearchFieldPage : BasePage
    {
        private IWebElement searchField => driver.FindElement(By.Id("s"));
        private IWebElement searchResultGera => driver.FindElement(By.CssSelector(".page-title"));
        private IWebElement searchResulBloga => driver.FindElement(By.CssSelector(".entry-title"));

        public SearchFieldPage(IWebDriver driver) : base(driver) { }

        public SearchFieldPage IvestiBlogaReiksme(string text)
        {
            searchField.Click();
            searchField.SendKeys(text);
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            builder.Build().Perform();
            return this;
        }
        public SearchFieldPage IvestiGeraReiksme(string text)
        {
            searchField.Click();
            searchField.SendKeys(text);
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            builder.Build().Perform();
            return this;
        }
        public SearchFieldPage AssertSearchReiksmeBloga(string text)
        {
            Assert.AreEqual(text, searchResulBloga.Text);
            return this;
        }
        public SearchFieldPage AssertSearchReiksmeGera(string text)
        {
            Assert.AreEqual(text, searchResultGera.Text);
            return this;
        }
    }
}