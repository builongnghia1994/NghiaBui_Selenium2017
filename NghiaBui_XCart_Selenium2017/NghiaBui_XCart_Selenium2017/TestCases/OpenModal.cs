using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NghiaBui_XCart_Selenium2017.Pages;
using NghiaBui_XCart_Selenium2017.Common;

namespace NghiaBui_XCart_Selenium2017
{
    [TestClass]
    public class OpenModal
 
    {
        Homepage homepage;
        [TestInitialize]
        public void TestInitializeMethod()
        {
            homepage = CommonAction.OpenHomepage(Constant.URL);
        }

        [TestMethod]
        public void OpenLRModal()
        {
            homepage = homepage.OpenLogin_RegisterModal();
        }

        [TestCleanup]
        public void TestCleanUpMethod()
        {
            Constant.WebDriver.Quit();
        }
    }
}
