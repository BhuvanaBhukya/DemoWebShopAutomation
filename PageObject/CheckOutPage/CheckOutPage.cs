using NUnit.Framework;
using OpenQA.Selenium;
using DemoWebShop.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace DemoWebShop.PageObject
{
    class CheckOutPage : BaseTest
    {

        IWebElement BillingAddressButton => driver.FindElement(By.CssSelector("#checkout-step-billing .new-address-next-step-button"));

        IWebElement ShippingAddressButton => driver.FindElement(By.CssSelector("#checkout-step-shipping .new-address-next-step-button")); 

        IWebElement ShippingMethodButton => driver.FindElement(By.CssSelector("#checkout-step-shipping-method .shipping-method-next-step-button")); 

        IWebElement PaymentMethodButton => driver.FindElement(By.CssSelector("#checkout-step-payment-method .payment-method-next-step-button")); 

        IWebElement PaymentInfoButton => driver.FindElement(By.CssSelector("#checkout-step-payment-info .payment-info-next-step-button"));

        IWebElement City => driver.FindElement(By.CssSelector("#BillingNewAddress_City")); 

        IWebElement AddressLine => driver.FindElement(By.Id("BillingNewAddress_Address1")); 

        IWebElement Postalcode => driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));

        IWebElement PhoneNumber => driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));

        IWebElement AddressDetails => driver.FindElement(By.Id("billing-address-select"));

        IWebElement Total => driver.FindElement(By.XPath("//*[@id='checkout-confirm-order-load']"));

        IWebElement ConfirmOrderButton => driver.FindElement(By.CssSelector("#checkout-step-confirm-order .confirm-order-next-step-button"));

        public void BillingAddressDetails()
        {
            Thread.Sleep(2000);
            if(AddressDetails.Displayed)
            {
                ClickBillingAddressButton();
                ClickShippingAddressButton();
                ClickShippingMethodButton();
                ClickPaymentMethodButton();
                ClickPaymentInfoButton();
                ClickConfirmOrderButton();
                Thread.Sleep(1000);
            }

            else
            {
                SelectCountry("country");
                SelectCity("city");
                SelectAddressLine("addressLine");
                SelectPostalcode("postalCode");
                SelectPhoneNumber("phoneNumber");
                ClickBillingAddressButton();
                ClickShippingAddressButton();
                ClickShippingMethodButton();
                ClickPaymentMethodButton();
                ClickPaymentInfoButton();
                ClickConfirmOrderButton();
                Thread.Sleep(1000);
            }
        }

        public void ClickBillingAddressButton()
        {
            BillingAddressButton.Click();
            Thread.Sleep(1000);
        }

        public void SelectCountry(string country)
        {
            IWebElement element = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement element1 = new SelectElement(element);
            Thread.Sleep(2000);
            element1.SelectByText("Australia");
            Thread.Sleep(2000);
        }

        public void SelectCity(string city)
        {
            City.SendKeys("Brisbane");
            Thread.Sleep(1000);
        }

        public void SelectAddressLine(string addressLine)
        {
            AddressLine.SendKeys("testtt");
            Thread.Sleep(1000);
        }

        public void SelectPostalcode(string postalCode)
        {
            Postalcode.SendKeys("4000");
            Thread.Sleep(1000);
        }

        public void SelectPhoneNumber(string phoneNumber)
        {
            PhoneNumber.SendKeys("041234567");
            Thread.Sleep(1000);
        }

        public void ClickShippingAddressButton()
        {
            ShippingAddressButton.Click();
            Thread.Sleep(1000);
        }

        public void ClickShippingMethodButton()
        {
            ShippingMethodButton.Click();
            Thread.Sleep(1000);
        }

        public void ClickPaymentMethodButton()
        {
            PaymentMethodButton.Click();
            Thread.Sleep(1000);
        }

        public void ClickPaymentInfoButton()
        {
            PaymentInfoButton.Click();
            Thread.Sleep(1000);
        }

        public void ClickConfirmOrderButton()
        {
            Assert.True(driver.FindElement(By.XPath("//*[@id='checkout-confirm-order-load']")).Text.Contains("Total"));
            ConfirmOrderButton.Click();
            Thread.Sleep(1000);
        }
    }
}
