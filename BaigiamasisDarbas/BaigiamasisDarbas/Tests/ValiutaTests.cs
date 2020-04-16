using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaigiamasisDarbas.Tests
{
    public class ValiutaTests : BaseTests
    {

        private ValiutaPage valiutaPage;

        [SetUp]
        public void BeforeTest()
        {
            driver.Url = "http://spekuliantas.com/fx_skaiciuoklis.php";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            valiutaPage = new ValiutaPage(driver);
        }

        [Test]
        public void SelectCurrency()
        {
            valiutaPage
                .RiskMoneyButton()
                .SelectValiuta();

            valiutaPage.AssertSelectValiuta("Pinigai, JPY");

        }
    }
}
