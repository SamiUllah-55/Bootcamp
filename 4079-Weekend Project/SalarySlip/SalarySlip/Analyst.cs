using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip
{
    class Analyst: Employee
    {
        public override void EmployeeInfo()
        {
            Console.WriteLine("Employee Type is Analyst");
            Salary salary = new Salary(150, 800);
            salary.Calculate_Gross_Salary();

        }
    }
}
