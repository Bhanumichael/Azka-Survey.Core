using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azka_Survey.Core.Core;

namespace Azka_Survey.Core.Pages
{
    public class LoginPage
    {
        IWebElement entername => DriverContext.Driver.FindElement(By.XPath("//input[@type='text']"));
        IWebElement enterpassword => DriverContext.Driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement loginpage => DriverContext.Driver.FindElement(By.XPath("//button[@type='submit']"));

        public void VerifyTheLoginPage()
        {
            Assert.IsTrue(entername.Displayed, "The LoginPage is not displayed");
        }
        public void Enterthename(string name)
        {
            entername.SendKeys(name);
        }
        public void Enterthepassword(string password)
        {
            enterpassword.SendKeys(password);
        }
        public void ClickForLogin()
        {
            loginpage.Click();
        }
    }
}
