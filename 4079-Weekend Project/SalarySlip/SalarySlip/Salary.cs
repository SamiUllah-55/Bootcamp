using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip
{
   public class Salary
    {
        public const int base_Salary = 1500;

        public int medical_Allowance;
        public int feul_Allowance;
        public int total_Salary;
        

        

        public Salary(int _medical_allowance, int _feul_allowance)
        {
            // TODO: Complete member initialization
            
            this.feul_Allowance = _feul_allowance;
            this.medical_Allowance = _medical_allowance;
        }

        public void Calculate_Gross_Salary()
        {
            total_Salary = base_Salary + feul_Allowance + medical_Allowance;
            Console.WriteLine("Gross Salary for Analyst is $ {0}", total_Salary);
        }

    }
}
