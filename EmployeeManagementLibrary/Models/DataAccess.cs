using System.Collections.Generic;
using System.Linq;
using EmployeeManagementLibrary.Data;
using MediatR;

namespace EmployeeManagementLibrary.Models
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new();

        public DataAccess()
        {
            _employees.Add( new EmployeeModel { Id = 1, FirstName = "Jeremy", LastName = "LaRose"});
            _employees.Add( new EmployeeModel { Id = 2, FirstName = "Dejan", LastName = "Stamenov"});
        }
        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        
        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            newEmployee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add( newEmployee );
            return newEmployee;
        }

        public void DeleteEmployee(int id)
        {
            var employeeToDelete = _employees.FirstOrDefault(e => e.Id == id);
            if( employeeToDelete != null )
                _employees.Remove(employeeToDelete);
        }

        public void UpdateEmployee(int id, string firstName, string lastName )
        {
            var employeeToUpdate = _employees.FirstOrDefault(e => e.Id == id);

            if (employeeToUpdate == null)
                return;
            
            employeeToUpdate.Id = id;
            employeeToUpdate.FirstName = firstName;
            employeeToUpdate.LastName = lastName;
        }
    }
}