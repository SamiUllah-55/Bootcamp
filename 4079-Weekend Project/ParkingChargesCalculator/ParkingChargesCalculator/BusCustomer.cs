using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChargesCalculator
{
    class BusCustomer : Customer
    {
        public override void CustomerInfo()
        {
            Console.WriteLine("Vehicle Type is Bus");
            Console.WriteLine("Please enter the number of hours  customer parked the Bus");
            double hours = Convert.ToInt32(Console.ReadLine());
            Parking_Calculator calculator = new Parking_Calculator(hours, 6, 1.5, 30.0);
            double totalcharges = calculator.CalculateCharges();
            Console.WriteLine("Bus Customer Parking charges are $ {0}", totalcharges);



        }
    }
}
