using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace DemoWebShop.BaseClass
{
    public class BaseTest
    {

        public static IWebDriver driver;

        public IWebDriver Driver()
        {
         if (driver == null)
            {
                Open();
            }
            return driver;
        }

    [SetUp]

    public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demowebshop.tricentis.com/";
            Console.WriteLine("Url got opened");
        }

    [TearDown]

    public void Close()

        {
            driver.Quit();
        }
    }
}
