using FluxdayAutomation.SeleniumUtils.Wrappers;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxdayAutomation.Components;

namespace FluxdayAutomation.PageObjects
{
    public class Pages
    {
        [ThreadStatic]
        public static AddAnEmployeePage NewEmployee;
        [ThreadStatic]
        public static AuthorizationPage Authorization;
        [ThreadStatic]
        public static UsersPage Users;
        [ThreadStatic]
        public static HomePage Home;
        [ThreadStatic]
        public static SideBarMenu SideBarMenu;
        [ThreadStatic]
        public static TeamsPage Teams;
        [ThreadStatic]
        public static EditUserInfoPage EditUser;
        [ThreadStatic]
        public static DevOpsPage DevOps;
        [ThreadStatic]
        public static HeaderNav Header;

        public static void Init()
        {
            NewEmployee = new AddAnEmployeePage();
            Authorization = new AuthorizationPage();
            Users = new UsersPage();
            Home = new HomePage();
            SideBarMenu = new SideBarMenu();
            Teams = new TeamsPage();
            EditUser = new EditUserInfoPage();
            DevOps = new DevOpsPage();
            Header = new HeaderNav();
        }
    }
}
