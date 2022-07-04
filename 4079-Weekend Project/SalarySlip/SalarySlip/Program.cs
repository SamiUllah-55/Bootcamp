using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
        reDirect:



            Console.WriteLine("Gross Salary Calculator for Employees");
            Console.WriteLine("Enter E for Engineers");
            Console.WriteLine("Enter M for Managers");
            Console.WriteLine("Enter A for Analysts");

            char input = Convert.ToChar(Console.ReadLine());

            switch (Char.ToUpper(input))
            {
                case 'E':
                    Engineer engineer = new Engineer();
                    engineer.EmployeeInfo();
                    Console.WriteLine(" ");
                    goto reDirect;

                case 'M':
                    Manager manager = new Manager();
                    manager.EmployeeInfo();
                   Console.WriteLine(" ");
                    goto reDirect;

                case 'A':
                    Analyst analyst = new Analyst();
                    analyst.EmployeeInfo();
                    Console.WriteLine(" ");
                    goto reDirect;
                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    Console.WriteLine(" ");
                    goto reDirect;



            }

            Console.ReadKey();





            
        }
    }
}
