using BaigiamasisDarbas.Page;
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

        private CheckNaudotojoVardasPage checkNaudotojoVardasPage;

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/forum/index.php?action=register";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            checkNaudotojoVardasPage = new CheckNaudotojoVardasPage(driver);
        }

        [Test]
        public void LaisvasUzimtas()
        {
            string naudotojoVardas = "Testas";
            string laisvas = "Naudotojo vardas laisvas";
            string uzimtas = "Naudotojo vardas užimtas";


            checkNaudotojoVardasPage
                .StartRegistration()
                .EnterUserName(naudotojoVardas)
                .ClickCheckButton();

            checkNaudotojoVardasPage.AssertIsUsedUserName(laisvas, uzimtas);
        }
    }
}
