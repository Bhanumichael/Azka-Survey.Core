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
        IWebElement enterreligion=> DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[15]"));
        IWebElement enterage => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[16]"));
        IWebElement entercaste => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[17]"));
        IWebElement enterward => DriverContext.Driver.FindElement(By.XPath("(//input[contains(text(),'')])[18]"));
        IWebElement saveandproceedbutton => DriverContext.Driver.FindElement(By.XPath("//button[@id='next_button']"));
        
        public void EnterName(string name)
        {
            entername.SendKeys(name);
        }
    }
}
