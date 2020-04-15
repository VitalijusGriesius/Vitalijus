using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Page
{
   public class BadRegistrationPage : BasePage
    {
        public BadRegistrationPage(IWebDriver driver) : base(driver) { }

        private IWebElement SubmitButton => driver.FindElement(By.Name("accept_agreement"));
        private IWebElement NaudotojoVardasField => driver.FindElement(By.Id("smf_autov_username"));
        private IWebElement ElPastasField => driver.FindElement(By.Name("email"));
        private IWebElement PasirinkiteSlaptazodiField => driver.FindElement(By.Name("passwrd1"));
        private IWebElement PatvirkinkiteSlaptazodiField => driver.FindElement(By.Name("passwrd2"));
        private IWebElement ParodytosRaidesField => driver.FindElement(By.Name("register_vv[code]"));
        private IWebElement PatikrinimoDaugybaField => driver.FindElement(By.Name("register_vv[q][1]"));
        private IWebElement RegistruotisButton => driver.FindElement(By.Name("regSubmit"));
        private IWebElement RegistrationError => driver.FindElement(By.ClassName("register_error"));

        public BadRegistrationPage StartRegistration()
        {
            SubmitButton.Click();
            return this;
        }
        public BadRegistrationPage EnterTextInNaudotojoVardasField(string text)
        {
            NaudotojoVardasField.SendKeys(text);
            return this;
        }
        public BadRegistrationPage EnterTextInElPastasField(string text)
        {
            ElPastasField.SendKeys(text);
            return this;
        }
        public BadRegistrationPage EnterTextInPasirinkSlaptazodiField(string text)
        {
            PasirinkiteSlaptazodiField.SendKeys(text);
            return this;
        }
        public BadRegistrationPage EnterTextInPatvirtinkSlaptazodiField(string text)
        {
            PatvirkinkiteSlaptazodiField.SendKeys(text);
            return this;
        }
        public BadRegistrationPage EnterTextInParodytosRaidesField(string text)
        {
            ParodytosRaidesField.SendKeys(text);
            return this;
        }
        public BadRegistrationPage EnterTextInPatikrinimoDaugybaField(string number)
        {
            PatikrinimoDaugybaField.SendKeys(number);
            return this;
        }
        public BadRegistrationPage ClickRegistruotisButton()
        {
            RegistruotisButton.Click();
            return this;
        }
        public BadRegistrationPage AssertIsBadRegistration(string text)
        {
            Assert.AreEqual(text, RegistrationError);
            return this;
        }


    }
}
