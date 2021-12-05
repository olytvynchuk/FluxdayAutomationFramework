using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluxdayAutomation.SeleniumUtils.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public abstract class BasePage
    {
        public virtual T ClickOnButton<T>(IWebElement button) where T : class, new()
        {
            button.Click();
            return new();
        }

        public T ChangeContext<T>() where T : class, new()
        {
            return new();
        }

    }
}
