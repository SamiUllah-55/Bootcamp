using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip
{
    class Engineer : Employee
    {
        public override void EmployeeInfo()
        {
            Console.WriteLine("Employee Type is Engineer");
            Salary salary = new Salary(100,150);
            salary.Calculate_Gross_Salary();

        }
    }
}
