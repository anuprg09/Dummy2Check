using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    internal class Login
    {
        public static IReadOnlyCollection<IWebElement> UserName;
        public static IReadOnlyCollection<IWebElement> Password;
        public static IReadOnlyCollection<IWebElement> LoginBtn;
        public static bool userTextBoxExits(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            var LoginBtn = driver.FindElements(By.Id("loginLink"));
            if (LoginBtn != null && LoginBtn.Count > 0)
            {
                LoginBtn[0].Click();
            }

            UserName = driver.FindElements(By.Id("UserName"));
            if (UserName != null && UserName.Count > 0)
                return false;
            else
                return false;
        }
    }
}
