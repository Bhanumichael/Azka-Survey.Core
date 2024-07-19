using Azka_Survey.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V124.Autofill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Azka_Survey.Pages
{
    public class HomePage
    {
        IWebElement enterNameofCandidate => DriverContext.Driver.FindElement(By.XPath("//div[@class='card-body']//input[@name='name']"));
        IWebElement enterGender => DriverContext.Driver.FindElement(By.XPath("(//input[@name='gender'])[1]"));
        IWebElement enterAddress => DriverContext.Driver.FindElement(By.XPath("//input[@name='address']"));
        IWebElement enterCountry => DriverContext.Driver.FindElement(By.XPath("//select[@class='form-control']"));
        IWebElement enterPhone => DriverContext.Driver.FindElement(By.XPath("//input[@name='phone']"));
        IWebElement enterTown => DriverContext.Driver.FindElement(By.XPath("//input[@name='town']"));
        IWebElement enterConstituencyMLA => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[12]"));
        IWebElement enterMandal => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[13]"));
        IWebElement enterConstituencyMP => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[14]"));
        IWebElement enterReligion => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[15]"));
        IWebElement enterAge => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[16]"));
        IWebElement enterCaste => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[17]"));
        IWebElement enterWard => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[18]"));
        IWebElement clicksaveAndProceedButton => DriverContext.Driver.FindElement(By.XPath("(//button[contains(text(),'')])[5]"));
        IWebElement enterTotalFamilyMembers => DriverContext.Driver.FindElement(By.XPath("//div[@class='mb-3']/select[@name='familymember' and @class='form-control']"));
        IWebElement enterNumberOfChildren => DriverContext.Driver.FindElement(By.XPath("//div[@class='mb-3']/select[@name='children' and @class='form-control']"));
        IWebElement enterNumberOfEarningPeople => DriverContext.Driver.FindElement(By.XPath("//select[@name='earningmembers' and @class='form-control']"));
        IWebElement enterTotalFemales => DriverContext.Driver.FindElement(By.XPath("//select[@name='females' and @class='form-control']"));
        IWebElement enterOccupation => DriverContext.Driver.FindElement(By.XPath("//select[@name='occupation' and @class='form-control']"));
        IWebElement enterTotalMales => DriverContext.Driver.FindElement(By.XPath("//div[@class='mb-3']/select[@name='totalmale' and @class='form-control']"));
        IWebElement saveAndProceedButton => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button']"));
        IWebElement enterNoOfEarners => DriverContext.Driver.FindElement(By.XPath("//select[@name='totalearner']"));
        IWebElement enterHowMuchDebt => DriverContext.Driver.FindElement(By.XPath("//select[@name='totaldebt']"));
        IWebElement enterSavingPerMonth => DriverContext.Driver.FindElement(By.XPath("//select[@name='savingpermonth']"));
        IWebElement enterInterestRate => DriverContext.Driver.FindElement(By.XPath("//select[@name='interestrate']"));
        IWebElement enterSourceOfDebt => DriverContext.Driver.FindElement(By.XPath("//select[@name='sourcedebt']"));
        IWebElement clickOnSaveAndProceed => DriverContext.Driver.FindElement(By.XPath("(//button[contains(text(),'')])[5]"));
        IWebElement enterStreetRoads => DriverContext.Driver.FindElement(By.XPath("//select[@name='streetroad']"));
        IWebElement enterTVRoads => DriverContext.Driver.FindElement(By.XPath("//select[@name='tvroads']"));
        IWebElement enterDistrictConnectionRoads => DriverContext.Driver.FindElement(By.XPath("//select[@name='districtroads']"));
        IWebElement enterTransportation => DriverContext.Driver.FindElement(By.XPath("//select[@name='transportation']"));
        IWebElement enterHospitals => DriverContext.Driver.FindElement(By.XPath("//select[@name='hospitals']"));
        IWebElement enterGovernmentSchoolFacility => DriverContext.Driver.FindElement(By.XPath("//select[@name='schoolfacility']"));
        IWebElement enterFacilityAndAvailability => DriverContext.Driver.FindElement(By.XPath("//select[@name='facilityandavailability']"));
        IWebElement enterVoteFor => DriverContext.Driver.FindElement(By.XPath("//select[@name='votefor']"));
        IWebElement clickOnSubmit => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button']"));
        IWebElement clickonDashboard => DriverContext.Driver.FindElement(By.XPath("//a[@href='https://www.azkasurvey.com/dashboard']"));
        IWebElement clickonviewfile => DriverContext.Driver.FindElement(By.XPath("//a[@href='https://www.azkasurvey.com/view/480']"));
        IWebElement clickonSignout => DriverContext.Driver.FindElement(By.XPath("//a[@href='#']"));
        IWebElement clickonUploadfile => DriverContext.Driver.FindElement(By.XPath("(//button[contains(text(),'')])[1]"));
        IWebElement uploadAFile => DriverContext.Driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement clickonback => DriverContext.Driver.FindElement(By.XPath("//a[@href='#']"));

        public void EnterNameCadidate(string name)
        {
            enterNameofCandidate.SendKeys(name);
        }
        public void ClickOnGender()
        {
            enterGender.Click();
        }
        public void EnterAddress(string address)
        {
            enterAddress.SendKeys(address);
        }
        public void EnterCountry(string country)
        {
            enterCountry.SendKeys(country);
        }
        public void EnterPhone(string phone)
        {
            enterPhone.SendKeys(phone);
        }
        public void EnterTown(string town)
        {
            enterTown.SendKeys(town);
        }
        public void EnterConstituencyMLA(string constituencyMLA)
        {
            enterConstituencyMLA.SendKeys(constituencyMLA);
        }
        public void EnterMandal(string mandal)
        {
            enterMandal.SendKeys(mandal);
        }
        public void EnterConstituencyMP(string constituencyMP)
        {
            enterConstituencyMP.SendKeys(constituencyMP);
        }
        public void EnterReligion(string religion)
        {
            enterReligion.SendKeys(religion);
        }
        public void EnterAge(string age)
        {
            enterAge.SendKeys(age);
        }
        public void EnterCaste(string caste)
        {
            enterCaste.SendKeys(caste);
        }
        public void EnterWard(string ward)
        {
            enterWard.SendKeys(ward);
        }
        public void ClickOnSaveAndProceed()
        {
            clicksaveAndProceedButton.Click();
        }
        public void EnterTotalFamilyMembers(string totalFamilyMembers)
        {
            enterTotalFamilyMembers.SendKeys(totalFamilyMembers);
        }
        public void EnterNumberOfChildren(string numberOfChildren)
        {
            enterNumberOfChildren.SendKeys(numberOfChildren);
        }
        public void EnterNumberOfEarningPeople(string numberOfEarningPeople)
        {
            enterNumberOfEarningPeople.SendKeys(numberOfEarningPeople);
        }
        public void EnterTotalFemales(string totalFemales)
        {
            enterTotalFemales.SendKeys(totalFemales);
        }
        public void EnterOccupation(string occupation)
        {
            enterOccupation.SendKeys(occupation);
        }
        public void EnterTotalMales(string totalMales)
        {
            enterTotalMales.SendKeys(totalMales);
        }
        public void SaveAndProceedButton()
        {
            saveAndProceedButton.Click();
        }
        public void EnterNoOfEarners(string noOfEarners)
        {
            enterNoOfEarners.SendKeys(noOfEarners);
        }
        public void EnterHowMuchDebt(string howMuchDebt)
        {
            enterHowMuchDebt.SendKeys(howMuchDebt);
        }
        public void EnterSavindPerMonth(string savindPerMonth)
        {
            enterSavingPerMonth.SendKeys(savindPerMonth);
        }
        public void EnterInterestRate(string interestRate)
        {
            enterInterestRate.SendKeys(interestRate);
        }
        public void EnterSourceOfDebt(string sourceOfDebt)
        {
            enterSourceOfDebt.SendKeys(sourceOfDebt);
        }
        public void ClickOnSaveAndProcees()
        {
            clickOnSaveAndProceed.Click();
        }
        public void EnterStreetRoads(string streetRoads)
        {
            enterStreetRoads.SendKeys(streetRoads);
        }
        public void EnterTVRoads(string tvRoads)
        {
            enterTVRoads.SendKeys(tvRoads);
        }
        public void EnterDistrictConnectionRoads(string districtRoads)
        {
            enterDistrictConnectionRoads.SendKeys(districtRoads);
        }
        public void EnterTransportation(string transportation)
        {
            enterTransportation.SendKeys(transportation);
        }
        public void EnterHospitals(string hospitals)
        {
            enterHospitals.SendKeys(hospitals);
        }
        public void EnterGovernmentSchoolFacility(string governmentSchoolFacility)
        {
            enterGovernmentSchoolFacility.SendKeys(governmentSchoolFacility);
        }
        public void EnterFacilityAndAvailability(string facilityAndAvailability)
        {
            enterFacilityAndAvailability.SendKeys(facilityAndAvailability);
        }
        public void EnterVoteFor(string voteFor)
        {
            enterVoteFor.SendKeys(voteFor);
        }
        public void ClickOnSubmit()
        {
            clickOnSubmit.Click();
        }
        public void ClickOnDashboard()
        {
            clickonDashboard.Click();
        }
        public void ClickOnViewfile()
        {
            clickonviewfile.Click();
        }
        public void ClickOnSignout()
        {
            clickonSignout.Click();
        }
        public void ClickOnUploadfile()
        {
            clickonUploadfile.Click();
        }
        public void UploadAFile()
        {
            uploadAFile.Click();
        }
    }
}






