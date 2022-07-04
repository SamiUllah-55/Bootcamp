using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChargesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
          
            redirecttoMenu:

            Console.WriteLine("Parking Charges Calculator");
            Console.WriteLine("Enter 1 to Calculate for Bike");
            Console.WriteLine("Enter 2 to Calculate for Car");
            Console.WriteLine("Enter 3 to Calculate for Bus");

            
           
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                  BikeCustomer bike = new BikeCustomer();
                  bike.CustomerInfo();
                  Console.WriteLine(" ");
                  goto redirecttoMenu;

                case 2:

                   CarCustomer car = new CarCustomer();
                   car.CustomerInfo();
                   Console.WriteLine(" ");
                   goto redirecttoMenu;

                case 3:

                    BusCustomer bus = new BusCustomer();
                    bus.CustomerInfo();
                    Console.WriteLine(" ");
                    goto redirecttoMenu;

                default:
                    Console.WriteLine("Invalid Option - Please Choose Available Option");
                    goto redirecttoMenu;
                    

            

            
            
        }

            
            Console.ReadKey();
        }
    }
}
