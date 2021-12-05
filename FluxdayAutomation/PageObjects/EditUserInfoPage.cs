using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class EditUserInfoPage : BasePage
    {
        public static IWebElement FluxdayPaneId => Driver.FindElement(By.XPath("//div[@id='pane3']"));
        public static IWebElement ButtonSave => Driver.FindElement(By.XPath("//input[@class='button alert right' and @name='commit']"));////input[@name='commit']
        public static IWebElement UserNameField => Driver.FindElement(By.XPath("//input[@id='user_name']"));
        public static IWebElement UserNickNameField => Driver.FindElement(By.XPath("//input[@id='user_nickname']"));
        public static IWebElement UserEmailField => Driver.FindElement(By.XPath("//input[@id='user_email']"));
        public static IWebElement UserEmployeeCodeField => Driver.FindElement(By.XPath("//input[@id='user_employee_code']"));
        public static IWebElement UserPasswordField => Driver.FindElement(By.XPath("//input[@id='user_password']"));
        public static IWebElement UserPasswordConfirmationField => Driver.FindElement(By.XPath("//input[@id='user_password_confirmation']"));
        public static IWebElement UserEmployeeRoleSelect => Driver.FindElement(By.XPath("//div[@id='s2id_user_role']"));
        public static IWebElement UserRoleEmployee => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee']"));
        public static IWebElement UserEmployeeRoleInput => Driver.FindElement(By.XPath("//div[@class='select2-search']//input[@class='select2-input']"));
        public static IWebElement ManagersSelectInput => Driver.FindElement(By.XPath("//ul[@class='select2-choices']"));// (By.XPath("//select[@id='user_manager_ids']"));
        public static IWebElement ManagersSelect => Driver.FindElement(By.XPath("//div[@id='select2-drop']"));
        public IWebElement SelectOptionAdminUser => Driver.FindElement(By.XPath("//ul[@class='select2-results']//div[contains(text(),'Admin')]"));
        public IWebElement SelectOptionEmployee1 => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee 1']"));
        public IWebElement SelectOptionEmployee2 => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee 2']"));
        public IWebElement SelectOptionTeamLead => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Team Lead']"));
        public IWebElement ButtonCancel => Driver.FindElement(By.XPath("//a[@class='btn cancel-btn']//span[text()='Cancel']"));

        public IWebDriver Current { get; }

        public T SetValueToUserFormField<T>(IWebElement field, string value) where T : class, new()
        {
            field.Click();
            field.Clear();
            field.SendKeys(value);
            return new();
        }
              

        public T SelectEmployeeRole<T>(string role) where T : class, new()
        {
            UserEmployeeRoleSelect.Click();
            UserRoleEmployee.Click();
            return new();
        }

        public T SelectEmployeeManager<T>(string manager) where T : class, new()
        {
            ManagersSelectInput.Click();
            SelectOptionTeamLead.Click();          
            return new();
        }
        public T ClickButtonSave<T>() where T : class, new()
        {
            ButtonSave.Click();
            return new();
        }

    }
}
