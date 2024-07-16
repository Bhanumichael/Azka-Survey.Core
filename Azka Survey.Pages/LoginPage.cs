using Azka_Survey.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace Azka_Survey.Pages
{
    public class LoginPage  
    {
        IWebElement entername => DriverContext.Driver.FindElement(By.XPath(""));
        IWebElement enterpassword => DriverContext.Driver.FindElement(By.XPath(""));
        IWebElement loginpage => DriverContext.Driver.FindElement(By.XPath(""));    



        public void verifyTheLoginPage()
        {
            Assert.IsTrue(entername.Displayed, "The LoginPage is not displayed");
        }

        public void Entername(string Name)
        {
            entername.SendKeys(Name);
        }
        public void Enterpassword(string Name)
        {
            enterpassword.SendKeys(Name);
        }
        public void ClickForLogin()
        {
            loginpage.Click();  
        }


    }
}
  