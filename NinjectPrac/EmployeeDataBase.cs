using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPrac
{
    public class EmployeeDataBase
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();

            ListEmployees.Add(new Employee(){Id = 1, Name = "Tim", Department= "IT"});
            ListEmployees.Add(new Employee(){Id = 2,Name = "Mike",Department = "HR"});
            ListEmployees.Add(new Employee(){Id = 3,Name = "Ashley",Department = "Sales"});
            return ListEmployees;

        }
    }
}
