using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BaigiamasisDarbas.Tests
{
    class BadRegistrationTests : BaseTests
    {
        private IWebElement SubmitButton => driver.FindElement(By.Name("accept_agreement"));
        private IWebElement NaudotojoVardasField => driver.FindElement(By.Id("smf_autov_username"));
        private IWebElement ElPastasField => driver.FindElement(By.Name("email"));
        private IWebElement PasirinkiteSlaptazodiField => driver.FindElement(By.Name("passwrd1"));
        private IWebElement PatvirkinkiteSlaptazodiField => driver.FindElement(By.Name("passwrd2"));
        private IWebElement ParodytosRaidesField => driver.FindElement(By.Name("register_vv[code]"));
        private IWebElement PatikrinimoDaugybaField => driver.FindElement(By.Name("register_vv[q][1]"));
        private IWebElement RegistruotisButton => driver.FindElement(By.Name("regSubmit"));
        private IWebElement RegistrationError => driver.FindElement(By.ClassName("register_error"));

        private IWebElement check => driver.FindElement(By.Id("smf_autov_username_img"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/forum/index.php?action=register";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]

        public void ErrorRegistration()
        {
            string naudotojoVardas = "Testas";
            string elPastas = "testas@testas.testas";
            string pasirinklaptazodi = "testas";
            string patvirtinkSlaptazodi = "testas";
            string Raides = "abcdef";
            string daugyba = "36";

            SubmitButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            NaudotojoVardasField.SendKeys(naudotojoVardas);
            ElPastasField.SendKeys(elPastas);
            PasirinkiteSlaptazodiField.SendKeys(pasirinklaptazodi);
            PatvirkinkiteSlaptazodiField.SendKeys(patvirtinkSlaptazodi);
            ParodytosRaidesField.SendKeys(Raides);
            PatikrinimoDaugybaField.SendKeys(daugyba);
            RegistruotisButton.Click();

            Assert.AreEqual("Jūsų registracijoje aptiktos šios klaidos. Norint tęsti, ištaisykite jas:\r\nJūsų įvesti simboliai neatitinka paveikslėlyje parodytų simbolių", RegistrationError.Text);
        }
    }
}
