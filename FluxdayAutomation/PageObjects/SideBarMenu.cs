using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class SideBarMenu : BasePage
    {        
        public IWebElement QuickSearchPlaceholder => Driver.FindElement(By.XPath("//input[@id='search_keyword']"));
        public IWebElement DashboardLink => Driver.FindElement(By.XPath("//a[@href= '/' and text()]"));
        public IWebElement MyTasksLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/tasks']"));
        public IWebElement DepartmentsLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/projects']"));
        public IWebElement TeamLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/teams']"));
        public IWebElement UsersLink => Driver.FindElement(By.XPath("//ul[@class='side-nav sidebar-links top-set']//*[@href='/users']"));
        public IWebElement OKRLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/okrs']"));
        public IWebElement ReportsLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/reports/worklogs']"));
        public IWebElement AdminUserLink => Driver.FindElement(By.XPath("//ul[@class='user-links side-nav sidebar-links']//a[@href='/users/FT1']"));
        public IWebElement LogOutLink => Driver.FindElement(By.XPath("//ul[@class='user-links side-nav sidebar-links']//a[@data-method='delete']"));

       

        //public override T ClickOnButton<T>(IWebElement button) : base
        //{
        //    button.Click();
        //    return new();
        //}
        public AuthorizationPage ReturnToAuthorizationPage()
        {
            ClickOnButton<AuthorizationPage>(LogOutLink);
            return new AuthorizationPage();
        }

        public T ClickOnLogOutButton<T>() where T : class, new()
        {
            LogOutLink.Click();
            return new();
        }
        public UsersPage GoToUsersPage()
        {
            Thread.Sleep(1000); 
            UsersLink.Click();
            return new();
        }
    }
}
