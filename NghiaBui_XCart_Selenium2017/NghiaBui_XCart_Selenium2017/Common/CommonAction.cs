using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NghiaBui_XCart_Selenium2017.Pages;

namespace NghiaBui_XCart_Selenium2017.Common
{
    static class CommonAction
    {
        public static Homepage OpenHomepage(string URL)
        {
            BrowserManager.Broswer.Navigate().GoToUrl(URL);
            return new Homepage();
        }
    }
}
