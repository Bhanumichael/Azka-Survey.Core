global using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Azka_Survey.Core;
using Azka_Survey.Pages;
namespace Azka_Survey.Tests
{
    [TestClass]
    public class AzkaSurvey_Tests : BaseTest
    {
        [TestMethod]
        public void VerifyThatUserCanLoginWithValidCredentials()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Enterthename(".testing@gmail.com");
            loginPage.Enterthepassword("");
            loginPage.ClickForLogin();
            homePage.EnterNameCadidate("");
            homePage.EnterGender("Male");
            homePage.EnterAddress("12");
            homePage.EnterCountry("AP");
            homePage.EnterPhone("123456789");
            homePage.EnterTown("Vinobhanagar");
            homePage.EnterConstituencyMLA("Ramangundam Constituency");
            homePage.EnterMandal("Ramangundam Mandal");
            homePage.EnterConstituencyMP("Pedhapalli Constituency");
            homePage.EnterReligion("Christian");
            homePage.EnterAge("25");
            homePage.EnterCaste("General");
            homePage.EnterWard("Ward 1");
            homePage.ClickOnSaveAndProceed();
        }

        [TestMethod]
        public void VerifyThatUserCannotLoginWithInvalidCredentials()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Enterthename("456789");
            loginPage.Enterthepassword("GGDlyk99@123");
            loginPage.ClickForLogin();
            homePage.EnterGender("6585");
            homePage.EnterAddress("r98nfic7w4");
            homePage.EnterCountry("funudsj");
            homePage.EnterPhone("983h83bsvbdhd");
            homePage.EnterTown("xjzyvfj");
            homePage.EnterConstituencyMLA("ahfebhsfb");
            homePage.EnterMandal(" svjdeavjd7343");
            homePage.EnterConstituencyMP("123456yujhvg");
            homePage.EnterReligion("ydafea7345783");
            homePage.EnterAge("2sffjafjaf5");
            homePage.EnterCaste("sdkWKDNB834");
            homePage.EnterWard("WarADSBJYEd 1");
            homePage.ClickOnSaveAndProceed();
        }
    }   
}   