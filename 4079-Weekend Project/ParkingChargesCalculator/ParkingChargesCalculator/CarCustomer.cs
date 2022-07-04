using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChargesCalculator
{
    class CarCustomer : Customer
    {
        public override void CustomerInfo()
        {
            Console.WriteLine("Vehicle Type is Bike");
            Console.WriteLine("Please enter the number of hours  customer parked Car");
            double hours = Convert.ToInt32(Console.ReadLine());
            Parking_Calculator calculator = new Parking_Calculator(hours, 4, 1.0, 20.0);
            double totalcharges = calculator.CalculateCharges();
            Console.WriteLine("Car Customer Parking charges are $ {0}", totalcharges);



        }
    }
}
