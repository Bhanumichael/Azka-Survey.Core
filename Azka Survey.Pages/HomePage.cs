using Azka_Survey.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V124.Autofill;
using System;
using System.Collections.Generic;
using System.Linq;
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
<<<<<<< HEAD
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
        IWebElement SaveAndProceedButton => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button' and @class='btn btn-primary ms-auto' and @onclick='next()' and text()='Save And Proceed']"));
=======
        IWebElement enterConstituencyMLA => DriverContext.Driver.FindElement(By.XPath("//input[@name='constituencyMLA']"));
        IWebElement enterMandal => DriverContext.Driver.FindElement(By.XPath("//input[@name='mandal']"));
        IWebElement enterConstituencyMP => DriverContext.Driver.FindElement(By.XPath("//input[@name='constituencyMP']"));
        IWebElement enterReligion => DriverContext.Driver.FindElement(By.XPath("//input[@name='religion']"));
        IWebElement enterAge => DriverContext.Driver.FindElement(By.XPath("//input[@name='age']"));
        IWebElement enterCaste => DriverContext.Driver.FindElement(By.XPath("//input[@name='caste']"));
        IWebElement enterWard => DriverContext.Driver.FindElement(By.XPath("//input[@name='ward']"));
        IWebElement saveAndProceedButton => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button']"));
        IWebElement clickonDashboard => DriverContext.Driver.FindElement(By.XPath("//a[@href='https://www.azkasurvey.com/dashboard']"));
        IWebElement clickonviewfile => DriverContext.Driver.FindElement(By.XPath("//a[@href='https://www.azkasurvey.com/view/480']"));
        IWebElement clickonSignout => DriverContext.Driver.FindElement(By.XPath("//a[@href='#']"));


>>>>>>> f35d3030b67477c49de5a1ae7c457d9bd93bd905

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
<<<<<<< HEAD
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
        public void saveAndProceedButton()
        {
            SaveAndProceedButton.Click();

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



    }
}
