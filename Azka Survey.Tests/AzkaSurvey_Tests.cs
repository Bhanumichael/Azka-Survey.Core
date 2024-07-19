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
            loginPage.Enterthename("bhanuprakash01.testing@gmail.com");
            loginPage.Enterthepassword("MUjJGb5O");
            loginPage.ClickForLogin();
            homePage.EnterNameCadidate("Bhanu");
            homePage.ClickOnGender();
            homePage.EnterAddress("Vinobhacolony");
            homePage.EnterCountry("Andhra Pradesh");
            homePage.EnterPhone("99999999");
            homePage.EnterTown("Vinobhanagar");
            homePage.EnterConstituencyMLA("Chander");
            homePage.EnterMandal("Ramangundam Mandal");
            homePage.EnterConstituencyMP("Pedhapalli Constituency");
            homePage.EnterReligion("Christian");
            homePage.EnterAge("25");
            homePage.EnterCaste("General");
            homePage.EnterWard("Ward 1");
            homePage.ClickOnSaveAndProceed();
        }

        [TestMethod]
        public void VerifyThatUserCanLoginAndCheckDashboardViews()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Enterthename("bhanuprakash01.testing@gmail.com");
            loginPage.Enterthepassword("MUjJGb5O");
            loginPage.ClickForLogin();
            homePage.ClickOnDashboard();
            homePage.ClickOnViewfile();
            homePage.ClickOnSignout();  

        }
    }   
}   