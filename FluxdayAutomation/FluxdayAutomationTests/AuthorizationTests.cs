using NUnit.Framework;
using FluxdayAutomation.PageObjects;
using FluxdayAutomation.Data;

using static FluxdayAutomation.Data.TestData.UsersEmails;
using static FluxdayAutomation.Data.TestData.Passwords;
using FluxdayAutomation.Components;

namespace FluxdayAutomation.FluxdayAutomationTests
{
    public class AuthorizationTests: BaseAppTest
    {
       

        [Test]
        [Description("TestCase(WI_10001), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10001_VerifyLoginToAppAsAdmin()
        {
            Pages.Authorization
                .LoginToApp<HeaderNav>(AdminUser, Password)
                .VerifyIfFluxdayLogoDisplayed<HeaderNav>(Pages.Header.FluxdayLogo);
        }

        [Test]
        [Description("TestCase(WI_10002), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10002_VerifyLoginToAppAsTeamLead()
        {
            Pages.Authorization
               .LoginToApp<HeaderNav>(TeamLead, Password)
               .VerifyIfFluxdayLogoDisplayed<HeaderNav>(Pages.Header.FluxdayLogo);
        }

        [Test]
        [Description("TestCase(WI_10003), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10003_VerifyLogOutFromApp()
        {
            Pages.Authorization
               .LoginToApp<SideBarMenu>(AdminUser, Password)
               .ReturnToAuthorizationPage()
               .VerifyIfFluxdayLoginLogoDisplayed();

        }

        [Test]
        [Description("TestCase(WI-10004), Processed (2021-08-29), Updated(2021-08-29)")]
        public void WI_10004_VerifyCheckBoxRememberMe()
        {
            Pages.Authorization
              .TypeTextToField<AuthorizationPage>(Pages.Authorization.EmailField, TeamLead)
               .TypeTextToField<AuthorizationPage>(Pages.Authorization.PasswordField, Password)
               .CheckUnCheckRememberMeCheckbox()
               .ClickOnLoginButton<SideBarMenu>()
               .ReturnToAuthorizationPage()
               .TypeTextToField<AuthorizationPage>(Pages.Authorization.EmailField, TeamLead)
               .ClickOnLoginButton<HeaderNav>()
               .VerifyIfFluxdayLogoDisplayed<HeaderNav>(Pages.Header.FluxdayLogo); 
        }

        [Test]
        [Description("TestCase(WI_10005), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10005_VerifyLogInWithIncorrectPassword()
        {
            var wrongPassword = TestDataGeneration.GenerateRandomAlphanumericString(8);
            Pages.Authorization
               .LoginToApp<AuthorizationPage>(AdminUser, wrongPassword)
               .VerifyIfFluxdayLoginLogoDisplayed();

        }

        [Test]
        [Description("TestCase(WI_10006), Processed(2021 - 08 - 28), Updated(2021 - 11 - 25)")]
        public void WI_10006_VerifyLogInWithIncorrectUserName()
        {
            var wrongUserName = TestDataGeneration.GenerateRandomAlphanumericString(15);
            Pages.Authorization
               .LoginToApp<AuthorizationPage>(wrongUserName, Password)
               .VerifyIfFluxdayLoginLogoDisplayed();
        }
    }
}

