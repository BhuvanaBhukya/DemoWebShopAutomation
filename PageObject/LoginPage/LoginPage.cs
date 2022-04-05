using NUnit.Framework;
using OpenQA.Selenium;
using System;
using DemoWebShop.BaseClass;
using System.Threading;

namespace DemoWebShop.PageObject
{
    class LoginPage : BaseTest

    {
        IWebElement Gender => driver.FindElement(By.Id("gender-female"));

        IWebElement FirstNameField => driver.FindElement(By.CssSelector("#FirstName"));

        IWebElement LastNameField => driver.FindElement(By.CssSelector("#LastName"));

        IWebElement EmailField => driver.FindElement(By.CssSelector("#Email"));

        IWebElement PasswordField => driver.FindElement(By.CssSelector("#Password"));

        IWebElement ConfirmPasswordField => driver.FindElement(By.CssSelector("#ConfirmPassword"));

        IWebElement RegisterButton => driver.FindElement(By.CssSelector("#register-button"));

        IWebElement LogInButton => driver.FindElement(By.CssSelector(".login-button"));


        public void Login()

        {
            SetEmail("email");
            SetPassword("passWord");
            ClickLogInButton();
            Console.WriteLine("Login successfully");
            Thread.Sleep(1000);
        }

        public void Register()

        {
            if (Gender.Displayed)
            {
                SelectGender();
                SetFirstName("firstName");
                SetLastName("lastName");
                SetEmail("email");
                SetPassword("passWord");
                SetConfirmPassword("confirmPassword");
                ClickRegisterButton();
                Console.WriteLine("Your registration completed");
                Thread.Sleep(1000);
            }

            else
            {
                Console.WriteLine("The specified email already exists");
            }
        }

        public void SelectGender()

        {
            Gender.Click();
            Thread.Sleep(1000);

        }

        public void SetFirstName(string firstName)

        {
            FirstNameField.SendKeys("Tester");
            Thread.Sleep(1000);

        }

        public void SetLastName(string lastName)

        {
            LastNameField.SendKeys("Testing");
            Thread.Sleep(1000);

        }

        public void SetEmail(string email)

        {
            EmailField.SendKeys("AutoTester523@gmail.com");
            Thread.Sleep(1000);

        }

        public void SetPassword(string passWord)

        {
            PasswordField.SendKeys("Tester@123");
            Thread.Sleep(1000);

        }

        public void SetConfirmPassword(string confirmPassword)

        {
            ConfirmPasswordField.SendKeys("Tester@123");
            Thread.Sleep(1000);

        }

        public void ClickRegisterButton()

        {
            RegisterButton.Click();
            Thread.Sleep(1000);
        }

        public void ClickLogInButton()

        {
            LogInButton.Click();
            Thread.Sleep(1000);
        }

    }

}
    
