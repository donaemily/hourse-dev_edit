using NUnit.Framework;
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

        IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            Loginpage loginpage = new Loginpage(driver);
            loginpage.loginsucess();
        }

        [TearDown]
        public void AfterTest()
        {
            Console.ReadKey();            
            driver.Quit();
        }

        //[Test]
        //public void TMCreatenVerify()
        //{
        //    Homepage homepage = new Homepage(driver);
        //    homepage.ClickAdmin();
        //    homepage.ClickTimenMaterial();

        //    Timenmaterialpage timenmaterialpage = new Timenmaterialpage(driver);
        //    timenmaterialpage.ClickCreateNewBtn();
        //    timenmaterialpage.EnterValidInfonSave();
        //    timenmaterialpage.ValidateTM();
        //}

        //[Test]
        //public void TMEditnVerify()
        //{
        //    Homepage homepage = new Homepage(driver);
        //    homepage.ClickAdmin();
        //    homepage.ClickTimenMaterial();

        //    Timenmaterialpage timenmaterialpage = new Timenmaterialpage(driver);
        //    timenmaterialpage.ClickonEditBtn();
        //    timenmaterialpage.ReenterValidInfoNSave();
        //}

        [Test]
        public void TMDelete()
        {
            Homepage homepage = new Homepage(driver);
            homepage.ClickAdmin();
            homepage.ClickTimenMaterial();

            Timenmaterialpage timenmaterialpage = new Timenmaterialpage(driver);
            timenmaterialpage.ClickDeleteBtn();

        }

    }
}
