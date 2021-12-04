using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;

namespace FluxdayAutomation.PageObjects
{
    public class HomePage : BasePage
    {      
        public IWebElement Entries => Driver.FindElement(By.XPath("//div[@class='title'and text()='Entries']"));
        public IWebElement TaskForTitle => Driver.FindElement(By.XPath("//div[@class='left' and contains(text(),'Tasks')]"));
        public IWebElement Week => Driver.FindElement(By.XPath("//a[@href='#week']"));
        public IWebElement Month => Driver.FindElement(By.XPath("//a[@href='#month']"));
        public IWebElement AddLogRightButton => Driver.FindElement(By.XPath("//a[@class='btn btn-sec right']"));
        public IWebElement AddLogLeftButton => Driver.FindElement(By.XPath("//a[@class='btn btn-sec left']"));
        public IWebElement PreviosIcon => Driver.FindElement(By.XPath("//div[@class='prev icon']"));
        public IWebElement NextIcon => Driver.FindElement(By.XPath("//div[@class='next icon']"));        
    }
}
