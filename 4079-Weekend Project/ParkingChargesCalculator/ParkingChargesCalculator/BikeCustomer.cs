using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChargesCalculator
{
    class BikeCustomer: Customer
    {
        public override void CustomerInfo()
        {

            Console.WriteLine("Vehicle Type is Bike");
            Console.WriteLine("Please enter the number of hours  customer parked Bike");
            double hours = Convert.ToInt32(Console.ReadLine());
            Parking_Calculator calculator = new Parking_Calculator(hours, 2, 0.5, 10.0);
            double totalcharges = calculator.CalculateCharges();
            Console.WriteLine("Bike Customer Parking charges are $ {0}", totalcharges); 
            
        }

    }
}
