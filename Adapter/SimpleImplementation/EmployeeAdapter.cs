using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsImplementation.Adapter.SimpleImplementation
{
    public class EmployeeAdapter : EmployeeManager ,IEmployeeAdapter
    {
        public override string GetAllEmployees()
        {
            var xml = base.GetAllEmployees();
            var employeeListInJSON = xml.Replace("XML", "JSON");
            return employeeListInJSON;
        }
    }
}
