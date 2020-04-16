using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BaigiamasisDarbas.Tests
{
    public class SkaiciuokleTests : BaseTests
    {

        private SkaiciuoklePage skaiciuoklePage;


        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            skaiciuoklePage = new SkaiciuoklePage(driver);
        }

        [Test]
        public void CountRiskSize()
        {
            var depozitoDydis = "1500";
            var RizikaPinigais = "280";
            var StopLoss = "30";
            var AskPrice = "1.3458";
            var RizikosDydisProc = "18.67";

            skaiciuoklePage
                .SelectCurrency()
                .ClickSwapRiskMOneyButton()
                .EnterTextInSizeField(depozitoDydis)
                .EnterTextInRiskField(RizikaPinigais)
                .EnterTextInStopLossField(StopLoss).SelectPair()
                .EnterTextInAskPriceField(AskPrice)
                .ClickCalculateRezult();

            skaiciuoklePage.AssertResult(RizikosDydisProc);
        }
    }
}
