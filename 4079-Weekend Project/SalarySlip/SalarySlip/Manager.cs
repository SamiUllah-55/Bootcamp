using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip
{
    class Manager:Employee
    {
        public override void EmployeeInfo()
        {
            Console.WriteLine("Employee Type is Manager");
            Salary salary = new Salary(250, 1000);
            salary.Calculate_Gross_Salary();

        }
    }
}
