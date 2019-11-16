using OpenQA.Selenium;
using System;

namespace hourse_dev_edit
{
    internal class Loginpage
    {
        IWebDriver driver;
        public Loginpage(IWebDriver d)
        {
            driver = d;
        }

        internal void loginsucess()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            IWebElement login = driver.FindElement(By.XPath("//input[contains(@id,'UserName')]"));
            login.SendKeys("hari");

            IWebElement password = driver.FindElement(By.XPath("//input[@id='Password']"));
            password.SendKeys("123123");

            IWebElement submit = driver.FindElement(By.XPath("//input[@type='submit']"));
            submit.Click();
        }
    }
}