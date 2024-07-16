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
        IWebElement entername => DriverContext.Driver.FindElement(By.XPath("//div[@class='card-body']//input[@name='name']"));
        IWebElement entergender => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[6]"));
        IWebElement enteraddress => DriverContext.Driver.FindElement(By.XPath("//input[contains(text(),'')])[9]"));
        IWebElement entercountry => DriverContext.Driver.FindElement(By.XPath("//select[@class='form-control']"));
        IWebElement enterphone => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[10]"));
        IWebElement entertown => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[11]"));
        IWebElement enterconstituencyMLA => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[12]"));
        IWebElement entermandal => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[13]"));
        IWebElement enterconstituencyMP => DriverContext.Driver.FindElement(By.XPath("//input[contains(text(),'')])[14]"));
        IWebElement enterreligion => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[15]"));
        IWebElement enterage => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[16]"));
        IWebElement entercaste => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[17]"));
        IWebElement enterward => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[18]"));
        IWebElement saveandproceedbutton => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button']"));

        public void EnterName(string name)
        {
            entername.SendKeys(name);
        }
        public void Entergender(string gender)
        {
            entergender.SendKeys(gender);
        }
        public void Enteraddress(string address)
        {
            enteraddress.SendKeys(address);
        }
        public void Entercountry(string country)
        {
            entercountry.SendKeys(country);
        }
        public void Enterphone(string phone)
        {
            enterphone.SendKeys(phone);
        }
        public void Entertown(string town)
        {
            entertown.SendKeys(town);
        }
        public void EnterconstituencyMLA(string constituencyMLA)
        {
            enterconstituencyMLA.SendKeys(constituencyMLA);
        }
        public void Entermandal(string entermandal)
        {
            entercaste.SendKeys(entermandal);   
        }
        public void EnterconstituencyMP(string constituencyMP)
        {
            enterconstituencyMP.SendKeys(constituencyMP);
        }
        public void Enterreligion(string religion)
        {
            enterreligion.SendKeys(religion);
        }
        public void Enterage(string age)
        {
            enterage.SendKeys(age);
        }
        public void Entercaste(string caste)
        {
            entercaste.SendKeys(caste);
        }
        public void Enterward(string ward)
        {
            enterward.SendKeys(ward);
        }
        public void ClickOnSaveAndProceed()
        {
            saveandproceedbutton.Click();
        }
    }
}
