using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    class CheckNaudotojoVardasPage : BasePage
    {

        private IWebElement SubmitButton => driver.FindElement(By.Name("accept_agreement"));
        private IWebElement NaudotojoVardasField => driver.FindElement(By.Id("smf_autov_username"));
        private IWebElement Check => driver.FindElement(By.Id("smf_autov_username_img"));

        public CheckNaudotojoVardasPage(IWebDriver driver) : base(driver) { }

        public CheckNaudotojoVardasPage StartRegistration()
        {
            SubmitButton.Click();
            return this;
        }
        public CheckNaudotojoVardasPage EnterUserName(string text)
        {
            NaudotojoVardasField.SendKeys(text);
            return this;
        }

        public CheckNaudotojoVardasPage ClickCheckButton()
        {
            Check.Click();
            return this;
        }
        public CheckNaudotojoVardasPage AssertIsUsedUserName(string text1, string text2)
        {
            if (Check.GetAttribute("title") == text1)
            {
                Assert.True(text1.Contains("laisvas"));
            }
            else if (Check.GetAttribute("title") == text2)
            {
                Assert.False(text2.Contains("laisvas"));
            }
            return this;
        }

    
    }
}
