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
            homePage.EnterPhone("9999999900");
            homePage.EnterTown("Vinobhanagar");
            homePage.EnterConstituencyMLA("Chander");
            homePage.EnterMandal("Ramangundam Mandal");
            homePage.EnterConstituencyMP("Pedhapalli Constituency");
            homePage.EnterReligion("Christian");
            homePage.EnterAge("25");
            homePage.EnterCaste("General");
            homePage.EnterWard("15");
            homePage.ClickOnSaveAndProceed();
            homePage.EnterTotalFamilyMembers("4");
            homePage.EnterNumberOfChildren("2");
            homePage.EnterNumberOfEarningPeople("2");
            homePage.EnterTotalFemales("2");
            homePage.EnterOccupation("Business");
            homePage.EnterTotalMales("2");
            homePage.SaveAndProceedButton();
            homePage.EnterNoOfEarners("2");
            homePage.EnterHowMuchDebt("10000");
            homePage.EnterSavindPerMonth("10000");
            homePage.EnterInterestRate("5");
            homePage.EnterSourceOfDebt("Bank Home Loan");
            homePage.ClickOnSaveAndProceed();
            homePage.EnterStreetRoads("Good");
            homePage.EnterTVRoads("Excellent");
            homePage.EnterDistrictConnectionRoads("Average");
            homePage.EnterTransportation("Better");
            homePage.EnterHospitals("Good");
            homePage.EnterGovernmentSchoolFacility("Good");
            homePage.EnterFacilityAndAvailability("Worse");
            homePage.EnterVoteFor("No");
            homePage.ClickOnSubmit();
        }
        [TestMethod]
        public void VerifyThatUserCanLoginAndCheckDashboardView()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Enterthename("bhanuprakash01.testing@gmail.com");
            loginPage.Enterthepassword("MUjJGb5O");
            loginPage.ClickForLogin();
            homePage.ClickOnDashboard();
            homePage.ClickOnViewfile();
            homePage.ClickOnSignout();
        }
        [TestMethod]
        public void VerifyThatUserCanLoginAndUploadaFiles()
        {
            uiHelpers.NavigateToUrl();
            loginPage.Enterthename("bhanuprakash01.testing@gmail.com");
            loginPage.Enterthepassword("MUjJGb5O");
            loginPage.ClickForLogin();
            loginPage.ClickForLogin();
            homePage.ClickOnUploadfile();
            homePage.UploadAFile();


        }
       
    }  
}