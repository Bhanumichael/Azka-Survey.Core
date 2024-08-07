using Azka_Survey.Core.Core;
using Azka_Survey.Core.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azka_survey.tests.Step_definitions
{
    public class BaseSteps
    {
        protected UiHelpers uiHelpers;
        protected LoginPage loginPage;
        protected HomePage homePage;

        [TestInitialize]
        public void StartTest()
        {
            DriverContext.StartDriver("Chrome");
            uiHelpers = new UiHelpers();
            loginPage = new LoginPage();
            homePage = new HomePage();
            uiHelpers.NavigateToUrl();
        }
    }
}
