using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
   public class KategorijosTests : BaseTests
    {

        private KategorijosPage kategorijosPage;


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            kategorijosPage = new KategorijosPage(driver);
        }

        [Test]

        public void KategorijosForexStrategijos()
        {
            string tekstas = "KATEGORIJOS ARCHYVAS: FOREX INDIKATORIAI";
            String URL = driver.Url;

            kategorijosPage
                .ClickForexIndikatoriai()
                .AssertCorrectPageIndikatoriai(tekstas)
                .ClickPradziaButton();

            kategorijosPage.AssertCorrectPagePradzia(URL);
        }
    }
}
