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
        AuthorizationPage loginPage = new AuthorizationPage();
        HeaderNav headerNav = new HeaderNav();

        [Test]
        [Description("TestCase(WI_10001), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10001_VerifyLoginToAppAsAdmin()
        {
            loginPage
                .LoginToApp<HeaderNav>(AdminUser, Password);
            Assert.That(headerNav.FluxdayLogo.Displayed);
        }

        [Test]
        [Description("TestCase(WI_10002), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10002_VerifyLoginToAppAsTeamLead()
        {
            loginPage                
                .LoginToApp<HeaderNav>(TeamLead, Password);
            Assert.That(headerNav.FluxdayLogo.Displayed);
        }

        [Test]
        [Description("TestCase(WI_10003), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10003_VerifyLogOutFromApp()
        {
            loginPage
                .LoginToApp<SideBarMenu>(AdminUser, Password)
                .ClickOnLogOutButton<AuthorizationPage>();
            Assert.That(loginPage.AuthorizationPageLogo.Displayed);
        }

        [Test]
        [Description("TestCase(WI-10004), Processed (2021-08-29), Updated(2021-08-29)")]
        public void WI_10004_VerifyCheckBoxRememberMe()
        {
            loginPage
               .TypeTextToField<AuthorizationPage>(loginPage.EmailField, TeamLead)
               .TypeTextToField<AuthorizationPage>(loginPage.PasswordField, Password)
               .CheckUnCheckRememberMeCheckbox()
               .ClickOnLoginButton<SideBarMenu>()
               .ReturnToAuthorizationPage()
               .TypeTextToField<AuthorizationPage>(loginPage.EmailField, TeamLead)
               .ClickOnLoginButton<HeaderNav>();
            Assert.That(headerNav.FluxdayLogo.Displayed);
        }

        [Test]
        [Description("TestCase(WI_10005), Processed(2021 - 08 - 28), Updated(2021 - 08 - 29)")]
        public void WI_10005_VerifyLogInWithIncorrectPassword()
        {
            var wrongPassword = TestDataGeneration.GenerateRandomAlphanumericString(8);
            loginPage
                .LoginToApp<AuthorizationPage>(AdminUser, wrongPassword);
            Assert.That(loginPage.LogInButton.Displayed);
        }

        [Test]
        [Description("TestCase(WI_10006), Processed(2021 - 08 - 28), Updated(2021 - 11 - 25)")]
        public void WI_10006_VerifyLogInWithIncorrectUserName()
        {
            var wrongUserName = TestDataGeneration.GenerateRandomAlphanumericString(15);
            loginPage
                .LoginToApp<AuthorizationPage>(wrongUserName, Password);
            Assert.That(loginPage.LogInButton.Displayed);
        }
    }
}

