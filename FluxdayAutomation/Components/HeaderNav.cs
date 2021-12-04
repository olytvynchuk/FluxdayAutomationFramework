using FluxdayAutomation.PageObjects;
using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.Components
{
    public class HeaderNav : BasePage
    {
        public IWebElement FluxdayLogo => Driver.FindElement(By.XPath("//div[@class='app-logo']"));
        public IWebElement AddNewTaskHeaderButton => Driver.FindElement(By.XPath("//a[@href='/tasks/new']"));
        public T ClickOnAddNewTaskButton<T>() where T : class, new()
        {
            AddNewTaskHeaderButton.Click();
            return new();
        }
    }
}
