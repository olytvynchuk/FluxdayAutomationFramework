using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using FluxdayAutomation.PageObjects;
using FluxdayAutomation.Data;

using static FluxdayAutomation.Data.TestData.Passwords;
using static FluxdayAutomation.Data.TestData.UsersEmails;
using static FluxdayAutomation.Data.TestData.EmployeesNames;
using static FluxdayAutomation.Data.TestData.EmployeesNickNames;
using static FluxdayAutomation.Data.TestData.EmployeesRoles;
using static FluxdayAutomation.Data.TestData;

namespace FluxdayAutomation.FluxdayAutomationTests
{
    public class TeamsTests : BasePage
    {       
        [Test]
        [Description("TestCase(WI_10009), Processed(2021 - 08 - 28), Updated(2021 - 11 - 25)")]
        public void WI_10009_VerifyIsNewUserWasCreated()
        {
            Pages.Authorization
               .LoginToApp<SideBarMenu>(AdminUser, Password)
                .GoToUsersPage()
                .ClickOnAddUserButton<AddAnEmployeePage>()
                .CreateNewUser<UsersPage>(ThirdEmployeeName, ThirdEmployee, Employee3, TestData.EmployeeCode, Employee, Password, TeamLeadName)
                .VerifyIfNewUserCreated(UsersPage.NewUserEmployee3Nick);
        }

        [Test]
        [Description("TestCase(WI_100010), Processed(2021 - 08 - 28), Updated(2021 - 11 - 25)")]
        public void WI_100010_VerifyEditUsersDataOptions()
        {
            Pages.Authorization
               .LoginToApp<SideBarMenu>(AdminUser, Password)
                .GoToUsersPage()
                .ChooseUserForDataEdition<UsersPage>(UsersPage.UserEmployee1)
                .ClickOnButton<UsersPage>(UsersPage.SettingsIcon)
                .ClickOnButton<EditUserInfoPage>(UsersPage.EditUserLink)
                .SetValueToUserFormField<EditUserInfoPage>(EditUserInfoPage.UserEmployeeCodeField, nameof(EmployeeCodes.FT5))
                .ClickButtonSave<UsersPage>();
        }
    }
}
