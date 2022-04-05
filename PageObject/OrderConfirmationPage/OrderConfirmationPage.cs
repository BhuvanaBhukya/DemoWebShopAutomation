using NUnit.Framework;
using OpenQA.Selenium;
using DemoWebShop.BaseClass;
using System.Threading;

namespace DemoWebShop.PageObject
{
    class OrderConfirmationPage : BaseTest
    {
        IWebElement OrderDetails => driver.FindElement(By.XPath("//a[contains(@href, 'orderdetails')]"));

        public void ConfirmOrder()
        {
            Assert.True(driver.PageSource.Contains("Your order has been successfully processed!"));
        }

        public void ClickOnOrderDetails()
        {
            OrderDetails.Click();
            Assert.True(driver.PageSource.Contains("Order information"));
            Thread.Sleep(1000);
        }
    }
}