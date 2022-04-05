using NUnit.Framework;
using OpenQA.Selenium;
using System;
using DemoWebShop.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace DemoWebShop.PageObject
{
    class ShoppingCartPage : BaseTest
    {

        IWebElement QuatityField => driver.FindElement(By.ClassName("qty-input"));

        IWebElement Update => driver.FindElement(By.Name("updatecart"));

        IWebElement TickBox => driver.FindElement(By.Id("termsofservice"));

        IWebElement CheckoutButton => driver.FindElement(By.XPath("//*[@id='checkout']"));

        public void SelectQuatity()
        {
            QuatityField.Clear();
            QuatityField.SendKeys("2");
            Update.Click();
            TickBox.Click();
            Thread.Sleep(1000);
        }

        public void ClickCheckoutButton()
        {
            CheckoutButton.Click();
            Thread.Sleep(2000);
        }

    }
}
