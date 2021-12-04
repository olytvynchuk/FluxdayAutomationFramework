using FluxdayAutomation.SeleniumUtils.Wrappers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class UsersPage : BasePage
    {
       
        public IWebElement FluxdayPaneId => Driver.FindElement(By.XPath("//div[@id='pane2']"));
        public static IWebElement AddNewUserBtn => Driver.FindElement(By.XPath("//a[@href='/users/new' and contains(text(),'Add user')]"));
        public IWebElement UsersPageTitle => Driver.FindElement(By.XPath("//div[@class='title' and text()='UsersEmails']"));

        public static IWebElement NewUserEmployee3Nick => Driver.FindElement(By.XPath("//div[@class='name']//div[@class= 'nickname' and text()='(emp3)']"));
        public static IWebElement SettingsIcon => Driver.FindElement(By.XPath("//div[@class='icon settings-link']"));
        public IWebElement DeleteUserLink => Driver.FindElement(By.XPath("//ul[@id='drop1']//a[@data-method= 'delete']"));
        public IWebElement UserAdminUser => Driver.FindElement(By.XPath("//a[@class='name' and text()='Admin User']"));
        public static IWebElement UserEmployee1 => Driver.FindElement(By.XPath("//a[@class='name' and text()='Employee 1']"));
        public IWebElement UserEmployee2 => Driver.FindElement(By.XPath("//a[@class='name' and text()='Employee 2']"));
        public IWebElement UserEmployee3 => Driver.FindElement(By.XPath("//a[@class='name' and text()='Employee 3']"));
        public IWebElement UserTeamLead => Driver.FindElement(By.XPath("//a[@class='name' and text()='Team Lead']"));
        public IWebElement UserNameRightSideTitle => Driver.FindElement(By.XPath("//div[@class='user-title']//div[@class='name']"));
        public static IWebElement EditUserLink => Driver.FindElement(By.XPath("//ul[@id='drop1']//a[text()='Edit']"));
        public static IWebElement ButtonSave => Driver.FindElement(By.XPath(""));
        

        public T ClickOnAddUserButton<T>() where T : class, new()
        { 
            AddNewUserBtn.Click();
            return new();
        }
        public UsersPage VerifyIfNewUserCreated(IWebElement element, bool expected = true) 
        { 
            var actual = element.Displayed;
            Assert.AreEqual(expected, actual);
            return new();
        }

        public T ChooseUserForDataEdition<T>(IWebElement userToEdit) where T : class, new() 
        {
            userToEdit.Click();
            Assert.That(UserNameRightSideTitle.Displayed);
            return new();
        }
        public T DeleteUser<T>() where T : class, new()
        {
            SettingsIcon.Click();
            DeleteUserLink.Click();
            return new();
        }
    }
}
