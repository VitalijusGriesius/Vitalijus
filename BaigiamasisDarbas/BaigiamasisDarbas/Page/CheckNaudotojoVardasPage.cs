using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
    class CheckNaudotojoVardasPage : BasePage
    {
        public CheckNaudotojoVardasPage(IWebDriver driver) : base(driver) { }

        private IWebElement SubmitButton => driver.FindElement(By.Name("accept_agreement"));
        private IWebElement NaudotojoVardasField => driver.FindElement(By.Id("smf_autov_username"));
        private IWebElement Check => driver.FindElement(By.Id("smf_autov_username_img"));

        public CheckNaudotojoVardasPage StartRegistration()
        {
            SubmitButton.Click();
            return this;
        }
        public CheckNaudotojoVardasPage IvedamNaudotojoVarda(string text)
        {
            NaudotojoVardasField.SendKeys(text);
            return this;
        }
        public CheckNaudotojoVardasPage AssertArLaisasArUzimtasVardas(string text)
        {
            if (Check.GetAttribute("title") == text)
            {
                Assert.True(text.Contains("text"));
            }
            else if (Check.GetAttribute("title") == text)
            {
                Assert.False(text.Contains("text"));
            }
            return this;
        }

    
    }
}
