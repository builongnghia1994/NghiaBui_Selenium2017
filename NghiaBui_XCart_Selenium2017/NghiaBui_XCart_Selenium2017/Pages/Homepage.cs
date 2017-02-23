using NghiaBui_XCart_Selenium2017.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NghiaBui_XCart_Selenium2017.Pages
{
    class Homepage
    {
        #region Xpath
        By btnLogin_Register = By.XPath("//div/button/span[text()='Sign in / sign up']");
        #endregion

        public IWebElement BtnLogin_Register
        {
            get
            {
                return Constant.WebDriver.FindElement(btnLogin_Register);
            }
        }


        #region Methods
        public Homepage OpenLogin_RegisterModal()
        {
            BtnLogin_Register.Click();
            return this;
        }

        #endregion
    }
}
