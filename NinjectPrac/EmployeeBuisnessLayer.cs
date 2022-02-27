using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPrac
{
    public class EmployeeBuisnessLayer
    {
        public EmployeeDataBase employeeData;

        public List<Employee> GetEmployees()
        {
            employeeData = new EmployeeDataBase();
            return employeeData.SelectAllEmployees();
        }
    }
}
