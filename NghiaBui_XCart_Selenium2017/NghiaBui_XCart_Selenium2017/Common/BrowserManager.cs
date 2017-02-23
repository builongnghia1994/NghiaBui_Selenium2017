using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NghiaBui_XCart_Selenium2017.Common
{
    class BrowserManager
    {
        public static IWebDriver Broswer
        {
            get
            {
                Uri uri = new Uri(Constant.URL);
                switch (Constant.Browser.ToLower())
                {
                    case "chrome":
                        Constant.WebDriver = new ChromeDriver();
                        break;
                    case "ie":
                        Constant.WebDriver = new InternetExplorerDriver();
                        break;
                    default:
                        Constant.WebDriver = new FirefoxDriver();
                        break;
                }
                Constant.WebDriver.Manage().Window.Maximize();
                return Constant.WebDriver;
            }
        }
    }
}
