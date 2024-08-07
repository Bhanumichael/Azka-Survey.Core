using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azka_Survey.Core.Core
{
    public class DriverContext
    {
        public static WebDriver Driver;

        public static WebDriver StartDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    Driver = new ChromeDriver();
                    break;

            }
            return Driver;
        }
    }
}
