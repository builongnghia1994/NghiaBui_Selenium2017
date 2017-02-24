using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NghiaBui_XCart_Selenium2017.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NghiaBui_XCart_Selenium2017.Pages
{
    class Homepage
    {
        public Homepage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        //#region Xpath
        //By btnLogin_Register = By.XPath("//div/button/span[text()='Sign in / sign up']");
        //By popLogin_Register = By.XPath("//form[@id='form-1487949730301']/../../../..");
        //#endregion

        //public IWebElement BtnLogin_Register
        //{
        //    get
        //    {
        //        return Constant.WebDriver.FindElement(btnLogin_Register);
        //    }
        //}

        //public IWebElement PopLogin_Register
        //{
        //    get
        //    {
        //        return Constant.WebDriver.FindElement(popLogin_Register);
        //    }
        //}

        //#region Methods
        //public Homepage OpenLogin_RegisterModal()
        //{
        //    BtnLogin_Register.Click();
        //    Thread.Sleep(2000);
        //    return this;
        //}

        //public bool CheckElementExist(IWebElement element)
        //{
        //    if (element.Displayed)
        //    {
        //        return true;
        //    }else { return false; }
        //}

        //public void VerifyElementExist(IWebElement element2)
        //{
        //    Assert.IsTrue(CheckElementExist(element2));
        //}

        //#endregion

        [FindsBy(How = How.XPath, Using = "//div/button/span[text()='Sign in / sign up']")]
        public IWebElement btnSignInSignUp;

        public Homepage OpenLoginRegisterModal()
        {
            btnSignInSignUp.Click();
            return this;
        }
    }
}
