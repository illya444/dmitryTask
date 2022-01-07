using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IEmployeeDAL
    {

        List<Employee> SelectAllEmployees();

    }

    public class EmployeeDAL : IEmployeeDAL
    {
       
            public List<Employee> SelectAllEmployees()
            {
                List<EmployeeDAL> ListEmployees = new List<Employee>();
                ListEmployees.Add(new EmployeeDAL()) { ID = 1, Name = "John", Department = "IT"});
                ListEmployees.Add(new EmployeeDAL()) { ID = 2, Name = "Mary", Department = "HR"});
                ListEmployees.Add(new EmployeeDAL()) { ID = 3, Name = "Scott", Department = "Payroll"});
                return ListEmployees;
            }
        
    }   
}