using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DesignPatternsImplementation.Adapter.SimpleImplementation
{
    public class EmployeeManager
    {
        List<Employee> _employeeList;
        public EmployeeManager()
        {
            //_employeeList = new List<Employee>() {
            //new Employee(){Id=1, Name="Pankaj"},
            // new Employee(){Id=2, Name="Nitika"},
            //  new Employee(){Id=3, Name="Sachin"},
            //};
        }
        public virtual string GetAllEmployees()
        {
            return "Employee List In XML";
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
