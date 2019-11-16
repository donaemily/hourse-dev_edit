using OpenQA.Selenium;
using System;
using System.Threading;

namespace hourse_dev_edit
{
    internal class Timenmaterialpage
    {
        IWebDriver driver;

        public Timenmaterialpage(IWebDriver d)
        {
            driver = d;
        }

        internal void ClickCreateNewBtn()
        {
            IWebElement createnew = driver.FindElement(By.XPath("//a[contains(.,'Create New')]"));
            createnew.Click();
        }

        internal void EnterValidInfonSave()
        {
            //IWebElement typecode = driver.FindElement(By.XPath("(//span[contains(@unselectable,'on')])[4]"));
            //typecode.Click();

            //IWebElement selecttypecode = driver.FindElement(By.XPath("(//li[contains(@tabindex,'-1')])[2]"));
            //selecttypecode.SendKeys("Time");

            IWebElement code = driver.FindElement(By.Name("Code"));
            code.SendKeys("dona1");

            IWebElement description = driver.FindElement(By.Name("Description"));
            description.SendKeys("testthis");

            IWebElement priceperunit = driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            priceperunit.SendKeys("$50.00");

            IWebElement save = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            save.Click();
        }             

        internal void ValidateTM()
        {
            Thread.Sleep(3000);
            while (true)
            {
                for (var i = 1; i <= 10; i++)
                {
                    IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                    IWebElement desc = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[3]"));

                    Console.WriteLine(code.Text);
                    if (code.Text == "dona" && desc.Text == "testthis")
                    {
                        Console.WriteLine("Test Success");
                        return;
                    }
                }

                IWebElement nextbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]/span"));
                nextbtn.Click();
            }            
        }

       
        internal void ClickonEditBtn()
        {
            Thread.Sleep(3000);

            while (true)
            {
                for (var i = 1; i <= 10; i++)
                {
                    IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));

                    if (code.Text == "donadonathomas")
                    {
                        IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[5]/a[1]"));
                        edit.Click();
                        return;
                    }
                }

                IWebElement nextbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]/span"));
                nextbtn.Click();
            }
            
        }

        internal void ReenterValidInfoNSave()
        {
            IWebElement code = driver.FindElement(By.Name("Code"));
            code.Clear();
            code.SendKeys("donathomas");

            IWebElement description = driver.FindElement(By.Name("Description"));
            description.SendKeys("testthis");

            IWebElement priceperunit = driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]"));
            priceperunit.Clear();
            priceperunit.SendKeys("150.00");

            IWebElement save = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            save.Click();
        }

        internal void ClickDeleteBtn()
        {
            Thread.Sleep(3000);

            while (true)
            {
                for (var i = 1; i <= 10; i++)
                {
                    IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));

                    if (code.Text == "donathomas")
                    {
                        IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[5]/a[2]"));
                        delete.Click();
                        return;
                    }
                }

                IWebElement nextbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]/span"));
                nextbtn.Click();
            }
        }

        internal void ConfirmDelete()
        {
            IWebElement confirmdelete = driver.FindElement(By.Name("Ok"));
            confirmdelete.Click();
        }


    }
}