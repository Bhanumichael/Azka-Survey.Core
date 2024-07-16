using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azka_Survey.Core
{
    public class UiHelpers
    {
        public void NavigateToUrl()
        {
            DriverContext.Driver.Navigate().GoToUrl("https://www.azkasurvey.com/");
            DriverContext.Driver.Manage().Window.Maximize();
        }

    }
}
