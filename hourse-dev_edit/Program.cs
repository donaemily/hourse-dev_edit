using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourse_dev_edit
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            IWebElement login = driver.FindElement(By.XPath("//input[contains(@id,'UserName')]"));
            login.SendKeys("hari");

            IWebElement password = driver.FindElement(By.XPath("//input[@id='Password']"));
            password.SendKeys("123123");

            IWebElement submit = driver.FindElement(By.XPath("//input[@type='submit']"));
            submit.Click();

            IWebElement admin = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            admin.Click();

            IWebElement timeandmaterial = driver.FindElement(By.XPath("//a[@href='/TimeMaterial']"));
            timeandmaterial.Click();

            List<IWebElement> edit = driver.FindElement(By.XPath("(//a[contains(@class,'k-button k-button-icontext k-grid-Edit')])[1]"));
            edit.Click();
       
            Console.ReadKey();
            driver.Quit();

        }
    }
}
