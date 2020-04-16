using BaigiamasisDarbas.Page;
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

        private BadRegistrationPage badRegistrationPage;

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/forum/index.php?action=register";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            badRegistrationPage = new BadRegistrationPage(driver);
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
            string Error = "Jūsų registracijoje aptiktos šios klaidos. Norint tęsti, ištaisykite jas:\r\nJūsų įvesti simboliai neatitinka paveikslėlyje parodytų simbolių";

            badRegistrationPage
                .StartRegistration()
                .EnterTextInUserNameField(naudotojoVardas)
                .EnterTextInEMailField(elPastas)
                .EnterTextInPasswordField(pasirinklaptazodi)
                .EnterTextInPassword2Field(patvirtinkSlaptazodi)
                .EnterTextInLettersField(Raides)
                .EnterTextInNumberField(daugyba)
                .ClickRegistrationButton();

            badRegistrationPage.AssertIsBadRegistration(Error);

        }
    }
}
