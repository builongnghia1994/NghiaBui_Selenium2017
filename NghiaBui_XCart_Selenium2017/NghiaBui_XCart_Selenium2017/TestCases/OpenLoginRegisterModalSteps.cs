using NghiaBui_XCart_Selenium2017.Common;
using NghiaBui_XCart_Selenium2017.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NghiaBui_XCart_Selenium2017.TestCases
{
    [Binding]
    class OpenLoginRegisterModalSteps
    {
        Homepage homepage = new Homepage();

        [Given(@"I have navigated to Homepage")]
        public void OpenURL()
        {
            BrowserManager.Broswer.Navigate().GoToUrl(Constant.URL);
        }

        [When(@"I click on Sign In/ Sign Up button")]
        public void WhenClickSignInSignUpbutton()
        {
            homepage.OpenLoginRegisterModal();
        }

        [Then(@"Login_RegisterModal displays")]
        public void ThenSignInSignUpModalDisplays()
        {

        }
    }
}
