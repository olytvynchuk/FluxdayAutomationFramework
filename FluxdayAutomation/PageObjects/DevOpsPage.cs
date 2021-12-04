using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class DevOpsPage: TeamsPage
    {       
        public IWebElement AddMemdersLink => Driver.FindElement(By.XPath("//a[@class='dashed_link transition' and contains(text(),'Add members')]"));
    }
}
