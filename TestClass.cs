using NUnit.Framework;
using DemoWebShop.BaseClass;
using DemoWebShop.PageObject;

namespace DemoWebShop

{
    [TestFixture()]
    public class TestClass : BaseTest
    {
        //as a user I want to register into DemoWebShop website
        [Test()]
        public void TestRegister()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickRegisterLink();
            loginPage.Register();
            homePage.VerifyLogin();
            homePage.ClickLogout();
            homePage.ClickLoginLink();
            loginPage.Login();
            homePage.VerifyLogin();
        }

        //as a user I want to login into DemoWebShop website with valid login details
        [Test()]
        public void TestLogin()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLoginLink();
            loginPage.Login();
            homePage.VerifyLogin();
            homePage.ClickLogout();
        }

        //as a user I want to browse all products in Demowebshop website
        [Test()]
        public void TestBrowsingProducts()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            CategoryPage categoryPage = new CategoryPage();

            homePage.ClickLoginLink();
            loginPage.Login();
            categoryPage.BrowseBooks();
            categoryPage.BrowseComputers();
            categoryPage.BrowseElectronics();
            categoryPage.BrowseApparelShoes();
            categoryPage.BrowseDigitalDownloads();
            categoryPage.BrowseJewelry();
            categoryPage.BrowseGiftCards();
        }

        //as a user I want to search products in search bar
        [Test()]
        public void TestSearch()
        {
            HomePage homePage = new HomePage();

            homePage.SearchProducts();
        }

        //as a user I want to login and purchase item in Demowebshop website
        [Test()]
        public void TestPurchase()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            CategoryPage categoryPage = new CategoryPage();
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage();
            CheckOutPage checkOutPage = new CheckOutPage();
            OrderConfirmationPage orderConfirmationPage = new OrderConfirmationPage();

            homePage.ClickLoginLink();
            loginPage.Login();
            categoryPage.BrowseApparelShoes();
            categoryPage.ShopJeans();
            homePage.ClickShoppingCart();
            shoppingCartPage.SelectQuatity();
            shoppingCartPage.ClickCheckoutButton();
            checkOutPage.BillingAddressDetails();
            orderConfirmationPage.ConfirmOrder();
            orderConfirmationPage.ClickOnOrderDetails();
        }
    }
}