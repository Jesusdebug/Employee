using DataLibraryEmployees.DataAccess;
using DataLibraryEmployees.Models;
using System.Collections.Generic;

namespace DataLibraryEmployees.BussinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstname, string lastName, string emailAddress, string password)
        {
            EmployeedModel data = new EmployeedModel
            {
                EmployeeId = employeeId,
                FirstName = firstname,
                LastName = lastName,
                EmailAddress = emailAddress,
                Password = password,
            };
            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress, Password)
                            values (@EmployeeId, @FirstName, @LastName, @EmailAddress, @Password)";
            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<EmployeedModel> loadEmployees()
        {
            string sql= @"SELECT  EmployeeId, FirstName, LastName, EmailAddress, Password FROM dbo.Employee";
            return SqlDataAccess.LoadData<EmployeedModel>(sql);
        }
    }
}
