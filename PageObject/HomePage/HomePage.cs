using NUnit.Framework;
using OpenQA.Selenium;
using DemoWebShop.BaseClass;
using System.Threading;

namespace DemoWebShop.PageObject
{
    class HomePage : BaseTest

    {
        IWebElement Books => driver.FindElement(By.XPath("//a[contains(@href, 'books')]"));

        IWebElement LoginLink => driver.FindElement(By.ClassName("ico-login"));

        IWebElement RegisterLink => driver.FindElement(By.ClassName("ico-register"));

        IWebElement LogoutLink => driver.FindElement(By.LinkText("Log out"));

        IWebElement SearchBar => driver.FindElement(By.CssSelector("#small-searchterms"));

        IWebElement SearchButton => driver.FindElement(By.XPath("//input[@type='submit']"));

        IWebElement ShoppingCart => driver.FindElement(By.ClassName("cart-label"));

        public void ClickLoginLink()

        {
            LoginLink.Click();
            Thread.Sleep(1000);

        }

        public void ClickRegisterLink()

        {
            RegisterLink.Click();
            Thread.Sleep(1000);

        }

        public void ClickLogout()

        {
            LogoutLink.Click();
            Thread.Sleep(1000);
        }

        public void VerifyLogin()

        {
            Assert.IsTrue(driver.PageSource.Contains("AutoTester523@gmail.com"));
            Thread.Sleep(1000);
        }

        public void FindSearchBar(string productName)

        {
            SearchBar.SendKeys("Blue Jeans");
            
            Thread.Sleep(1000);
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
            Thread.Sleep(2000);
        }

        public void SearchProducts()
        {
            FindSearchBar("productName");
            ClickSearchButton();
            Assert.True(driver.FindElement(By.ClassName("product-item")).Text.Contains("Blue Jeans"));
            Thread.Sleep(1000);
        }

        public void ClickShoppingCart()
        {
            ShoppingCart.Click();
            Thread.Sleep(1000);
        }
    }
}
