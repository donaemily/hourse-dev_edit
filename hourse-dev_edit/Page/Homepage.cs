using OpenQA.Selenium;
using System;

namespace hourse_dev_edit
{
    internal class Homepage
    {
        IWebDriver driver;

        public Homepage(IWebDriver d)
        {
            driver = d;
        }
        internal void ClickAdmin()
        {
            IWebElement admin = driver.FindElement(By.XPath("//a[contains(@role,'button')]"));
            admin.Click();
        }

        internal void ClickTimenMaterial()
        {
            IWebElement timeandmaterial = driver.FindElement(By.XPath("//a[@href='/TimeMaterial'][contains(.,'Time & Materials')]"));
            timeandmaterial.Click();
        }
    }
}