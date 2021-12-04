using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using FluxdayAutomation.SeleniumUtils.Wrappers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class AuthorizationPage : BasePage
    {   

        public IWebElement AuthorizationPageLogo => Driver.FindElement(By.XPath("//div[@class='app-logo-login']"));
        public IWebElement EmailField => Driver.FindElement(By.Id("user_email"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("user_password"));
        public IWebElement RememberMeCheckbox => Driver.FindElement(By.XPath("//input[@id='user_remember_me']"));
        public IWebElement RememberMeLabel => Driver.FindElement(By.XPath("//*[text()='Remember_me']"));
        public IWebElement LogInButton => Driver.FindElement(By.XPath("//button[@class='btn-login']"));
        public IWebElement UnsuccesfullLoginAlert => Driver.FindElement(By.XPath("//div[contains (@class,'alert')]"));

        

        public T TypeTextToField<T>(IWebElement fieldName, string text) where T: class, new() 
        {
            fieldName.Click();
            fieldName.Clear();
            fieldName.SendKeys(text);
            return new();
        }

        public T ClickOnLoginButton<T> () where T: class, new()
        {
            LogInButton.Click();
            return new();
        }
        
        public T LoginToApp<T>(string userName, string password) where T : class, new()
        {
            TypeTextToField<T>(EmailField, userName);
            TypeTextToField<T>(PasswordField, password);
            ClickOnLoginButton<T>();
            return new();
        }

        public AuthorizationPage CheckUnCheckRememberMeCheckbox()
        {
            RememberMeCheckbox.Click();
            return this;
        }
    }
}
