using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Azka_Survey.Core
{
    public class DriverContext
    {
        public static WebDriver Driver;
        public static WebDriver StartDriver(string browser)
        {
            switch (browser) 
            {
                case "Chrome":
                    Driver=new ChromeDriver();
                    break;  
            }
            return Driver;  
        }
    }
}
