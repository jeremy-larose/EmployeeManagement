using System.Collections.Generic;
using EmployeeManagementLibrary.Data;

namespace EmployeeManagementLibrary.Models
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel AddEmployee(string firstName, string lastName);
        void DeleteEmployee(int id);
        void UpdateEmployee(int id, string firstName, string lastName );
    }
}