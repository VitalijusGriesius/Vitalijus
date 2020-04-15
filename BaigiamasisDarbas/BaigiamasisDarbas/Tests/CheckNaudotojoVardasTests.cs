using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BaigiamasisDarbas.Tests
{
   public class CheckNaudotojoVardasTests : BaseTests
    {
        private IWebElement SubmitButton => driver.FindElement(By.Name("accept_agreement"));
        private IWebElement NaudotojoVardasField => driver.FindElement(By.Id("smf_autov_username"));
        private IWebElement Check => driver.FindElement(By.Id("smf_autov_username_img"));

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/forum/index.php?action=register";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void LaisvasUzimtas()
        {
            string naudotojoVardas = "Testas";
            string laisvas = "Naudotojo vardas laisvas";
            string uzimtas = "Naudotojo vardas užimtas";

            SubmitButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            NaudotojoVardasField.SendKeys(naudotojoVardas);

            Check.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            if (Check.GetAttribute("title") == laisvas)
            {
                Assert.True(laisvas.Contains("laisvas"));
            }
            else if (Check.GetAttribute("title") == uzimtas)
            {
                Assert.False(laisvas.Contains("užimtas"));
            }
        }
    }
}
