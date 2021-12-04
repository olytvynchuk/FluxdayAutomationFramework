using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.IO;


namespace FluxdayAutomation.SeleniumUtils.Wrappers
{
    public static class Driver
    { 

        private static IWebDriver _driver;

        private static  WebDriverWait _webDriverWait;

    


        public static void Init()
        {
            _driver = new ChromeDriver(Path.GetFullPath("@../../../../../../_drivers"));          
        }       

        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null.");

        public static void Goto(string url)
        {
            if (!url.StartsWith("https"))
            {
                url = $"https://{url}";
            }
            Current.Manage().Window.Maximize();
            Current.Manage().Cookies.DeleteAllCookies();
            Debug.WriteLine(url);
            Current.Navigate().GoToUrl(url);
        }
        
        public static IWebElement FindElement(By by)
        {
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            return nativeWebElement;
        }
                
    }
}

