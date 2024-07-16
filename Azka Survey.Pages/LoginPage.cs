using Azka_Survey.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace Azka_Survey.Pages
{
    public class LoginPage
    {
        IWebElement entername => DriverContext.Driver.FindElement(By.XPath("//input[@type='text']"));
        IWebElement enterpassword => DriverContext.Driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement loginpage => DriverContext.Driver.FindElement(By.XPath("//button[@type='submit']"));


        public void verifyTheLoginPage()
        {
            Assert.IsTrue(entername.Displayed, "The LoginPage is not displayed");
        }

        public void Entername(string Name)
        {
            entername.SendKeys(Name);
        }
        public void Enterpassword(string password)
        {
            enterpassword.SendKeys(password);
        }
        public void ClickForLogin()
        {
            loginpage.Click();
        }


    }
}
