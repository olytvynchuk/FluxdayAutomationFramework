using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class TeamsPage : BasePage
    {
       
        public IWebElement TeamsPageTitle => Driver.FindElement(By.XPath("//div[@class='title' and text()='Teams']"));
        public IWebElement TeamNameLink(string teamName) => Driver.FindElement(By.XPath("//a[@class='grey-link' and text()='${teamName}']"));
        public IWebElement AddTaskRightBtn(string teamId) => Driver.FindElement(By.XPath("//a[contains(@href,'${teamId}') and text()='Add task']"));////div[@class='team-glymplse']//a[contains(@href,'team_id=3')]
        public IWebElement DepartmentsLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/projects']"));
        public IWebElement TeamLink => Driver.FindElement(By.XPath("//div[@class='show-for-small']//a[@href='/teams']"));
        //public IWebElement        
    }
}
