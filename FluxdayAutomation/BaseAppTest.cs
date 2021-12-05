using NUnit.Framework;
using System;
using FluxdayAutomation.SeleniumUtils.Wrappers;

using static FluxdayAutomation.Data.Urls.CommonUrls;
using FluxdayAutomation.PageObjects;

namespace FluxdayAutomation
{
    public abstract class BaseAppTest
    {
        [SetUp]
        public void Initialize()
        {
            Driver.Init();            
            Driver.Goto(BasePageUrl);
            Console.WriteLine("Opened url");
        }
        public T ChangeContext<T>() where T : BaseAppTest, new()
        {
            return TestStepContext<T>.Instance;
        }


        [TearDown]
        public void AfterEachTestCleanup()
        {
            Driver.Current.Quit();
            Console.WriteLine("Closed app");
        }
    }    
}
