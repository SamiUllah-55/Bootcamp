using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingChargesCalculator
{
    class Parking_Calculator
    {
        double min_Charge;
        double sur_Charge;
        double max_Charge;
        const int basic_hours = 3;
        const int max_Hours = 24;
        private double _hours;

        public Parking_Calculator(double hours, double mincharge, double surcharge, double maxcharge)
        {
            Hours = hours;
         
            this.min_Charge = mincharge;
            this.sur_Charge = surcharge;
            this.max_Charge = maxcharge;
        }

        public double Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new Exception("You Entered invalid input");
                }
                else
                {
                    _hours = value;
                }
            }
        }

        public double CalculateCharges()
        {
            double totalCharge;
            if (Hours <= 3)
            {
                totalCharge =  Hours * min_Charge;

            }
            else
            {
                 
                totalCharge = (min_Charge * basic_hours) + ((Hours - basic_hours) * min_Charge + sur_Charge);
            }

            if (totalCharge > max_Charge)
            {
                totalCharge = max_Charge;
            }

            return totalCharge;
        }
    }
}
