using Azka_Survey.Core;
using Azka_Survey.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azka_Survey.Tests
{
    public class BaseTest
    {
        protected UiHelpers uiHelpers;  
        protected LoginPage loginPage; 
        protected HomePage  homePage;   

        [TestInitialize]
        public void StartTest() 
        {
            DriverContext.StartDriver("Chrome");
            uiHelpers = new UiHelpers();    
            loginPage = new LoginPage();        
            homePage = new HomePage();      
        }
        [TestCleanup]
        public void StopTest()
        { 
            DriverContext.Driver.Quit();    
        }
        
    }
}
