

namespace FluxdayAutomation.Data
{
    public class TestData
    {
        public const string EmployeeCode = "OKR";
        public static class UsersEmails
        {
            public const string
                AdminUser = "admin@fluxday.io",
                Employee1 = "emp1@fluxday.io",
                Employee2 = "emp2@fluxday.io",
                Employee3 = "emp3@fluxday.io",
                Employee4 = "emp4@fluxday.io",
                TeamLead = "lead@fluxday.io";                
        }
        public static class EmployeesRoles 
        {
            public const string
                Employee = "Employee",
                Manager = "Manager";
        }

        public static class EmployeesNickNames 
        {
            public const string
                Admin = "admin",
                FirstEmployee = "emp1",
                SecondEmployee = "emp2",
                ThirdEmployee = "emp3",
                FourthEmployee = "emp4",
                Lead = "lead";
        }
        public static class EmployeesNames
        {
            public const string
                AdminName = "Admin User",
                FirstEmployeeName = "Employee1",
                SecondEmployeeName = "Employee2",
                ThirdEmployeeName = "Employee3",
                FourthEmployeeName = "Employee4",
                TeamLeadName = "Team Lead";
        }

        public static class Passwords 
        {
            public const string Password = "password";           
        }

        public enum EmployeeCodes 
        {
            FT1=0,
            FT2,
            FT3,
            FT4,
            FT5,
            FT6,
            FT7
        }

        public static class TeamsNames
        {
            public const string
                DevOps = "DevOps",
                Fedena = "Fedena Development",
                Support = "Support",
                Testing = "Testing",
                Design = "UI/UX Design",
                Uzity = "Uzity Development";
        }        
    }
}
