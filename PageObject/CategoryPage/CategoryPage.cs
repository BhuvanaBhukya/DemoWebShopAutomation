using NUnit.Framework;
using OpenQA.Selenium;
using System;
using DemoWebShop.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace DemoWebShop.PageObject

{
    public class CategoryPage : BaseTest
    {
        IWebElement Books => driver.FindElement(By.XPath("//a[contains(@href, 'books')]"));

        IWebElement Computers => driver.FindElement(By.XPath("//a[contains(@href, 'computers')]"));

        IWebElement Electronics => driver.FindElement(By.XPath("//a[contains(@href, 'electronics')]"));

        IWebElement ApparelShoes => driver.FindElement(By.XPath("//a[contains(@href, 'apparel-shoes')]"));

        IWebElement DigitalDownloads => driver.FindElement(By.XPath("//a[contains(@href, 'digital-downloads')]"));

        IWebElement Jewelry => driver.FindElement(By.XPath("//a[contains(@href, 'jewelry')]"));

        IWebElement GiftCards => driver.FindElement(By.XPath("//a[contains(@href, 'gift-cards')]"));

        IWebElement JeansItem => driver.FindElement(By.LinkText("Blue Jeans"));

        IWebElement AddJeansItem => driver.FindElement(By.Id("add-to-cart-button-36"));


        public void ShopJeans()

        {
            SelectJeansItem();
            AddJeans();
        }

        public void BrowseBooks()
        {
            Books.Click();
            Thread.Sleep(1000);
        }

        public void BrowseComputers()

        {
            Computers.Click();
            Thread.Sleep(1000);
        }

        public void BrowseElectronics()

        {
            Electronics.Click();
            Thread.Sleep(1000);
        }

        public void BrowseApparelShoes()

        {
            ApparelShoes.Click();
            Thread.Sleep(1000);
        }

        public void BrowseDigitalDownloads()

        {
            DigitalDownloads.Click();
            Thread.Sleep(1000);
        }

        public void BrowseJewelry()

        {
            Jewelry.Click();
            Thread.Sleep(1000);
        }

        public void BrowseGiftCards()

        {
            GiftCards.Click();
            Thread.Sleep(1000);
        }

        public void SelectJeansItem()

        {
            JeansItem.Click();
            Thread.Sleep(1000);
        }

        public void AddJeans()

        {
            AddJeansItem.Click();
            Thread.Sleep(1000);
        }

    }
}
