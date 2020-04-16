using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class NuorodaTests : BaseTests
    {

        private NuorodaPage nuorodaPage;


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/brokeriai/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            nuorodaPage = new NuorodaPage(driver);
        }

        [Test]

        public void AssertIsCorrectBitcoinLink()
        {
            string tekstas = "Bitkoinai – ką žinome apie kriptovaliutą";

            nuorodaPage.LinkBitcoinClick();

            nuorodaPage.AssertIsCorrectLink(tekstas);

        }
    }
}
