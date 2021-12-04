using FluxdayAutomation.SeleniumUtils.Wrappers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxdayAutomation.PageObjects
{
    public class AddAnEmployeePage : BasePage
    {
        public IWebElement FluxdayPaneId => Driver.FindElement(By.XPath("//div[@id='pane3']"));
        public IWebElement SaveButton => Driver.FindElement(By.XPath("//div[@class='small-12 columns form-action-up']//div['Add an employee' ]//input['Save']"));
        public IWebElement UserNameField => Driver.FindElement(By.XPath("//input[@id='user_name']"));
        public IWebElement UserNickNameField => Driver.FindElement(By.XPath("//input[@id='user_nickname']"));
        public IWebElement UserEmailField => Driver.FindElement(By.XPath("//input[@id='user_email']"));
        public IWebElement UserEmployeeCodeField => Driver.FindElement(By.XPath("//input[@id='user_employee_code']"));
        public IWebElement UserPasswordField => Driver.FindElement(By.XPath("//input[@id='user_password']"));
        public IWebElement UserPasswordConfirmationField => Driver.FindElement(By.XPath("//input[@id='user_password_confirmation']"));
        public IWebElement UserEmployeeRoleSelect => Driver.FindElement(By.XPath("//div[@id='s2id_user_role']"));
        public IWebElement UserRoleEmployee => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee']"));
        public IWebElement UserEmployeeRoleInput => Driver.FindElement(By.XPath("//div[@class='select2-search']//input[@class='select2-input']"));
        public IWebElement ManagersSelectInput => Driver.FindElement(By.XPath("//select[@id='user_manager_ids']"));//("//ul[@class='select2-choices']"));manager_ids']"));
        public IWebElement ManagersSelect => Driver.FindElement(By.XPath("//li[@class='select2-search-field']//input[@class='select2-input']"));
        public IWebElement SelectOptionAdminUser => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Admin User']"));
        public IWebElement SelectOptionEmployee1 => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee 1']"));
        public IWebElement SelectOptionEmployee2 => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Employee 2']"));
        public IWebElement SelectOptionTeamLead => Driver.FindElement(By.XPath("//ul[@class='select2-results']//*[text()='Team Lead']"));
        public IWebElement ButtonCancel => Driver.FindElement(By.XPath("//a[@class='btn cancel-btn']//span[text()='Cancel']"));
              

        public void SetValueToUserFormField(IWebElement field, string value)
        {
            field.Click();
            field.Clear();
            field.SendKeys(value);
        }

        public T CreateNewUser<T>(string newUserName, string nickName, string eMail, string employeeCode,
            string employeeRole, string password, string manager) where T : class, new()
        {
            SetValueToUserFormField(UserNameField, newUserName);
            SetValueToUserFormField(UserNickNameField, nickName);
            SetValueToUserFormField(UserEmailField, eMail);
            SetValueToUserFormField(UserEmployeeCodeField, employeeCode);
            SelectEmployeeRole(employeeRole);
            SetValueToUserFormField(UserPasswordField, password);
            SetValueToUserFormField(UserPasswordConfirmationField, password);
            SelectEmployeeManager(manager);
            ClickOnButton<UsersPage>(SaveButton);
            return new ();
        }

        public void SelectEmployeeRole(string role)
        {
            UserEmployeeRoleSelect.Click();
            UserRoleEmployee.Click();          
        }

        public void SelectEmployeeManager(string manager)
        {
            ManagersSelectInput.Click();
            SelectOptionTeamLead.Click();
        }
    }
}
