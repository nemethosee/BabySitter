using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babysitter
{
    public class BabySitter
    {
        static void Main(string[] args)
        {
        }

        // Method   :   CalculateTotalPay
        //
        // Descr.   :   
        //              
        //              
        //              
        //              
        // Input    :   string  Family - family type can be A, B or C
        //              byte    StartHour - exact hour when the babysitter starts
        //              byte    EndHour - exact hour when the babysitter finishes
        //
        // Output   :   string  TotalPay
        
        
        private bool ValidateFamilyIndex(string Family)
        {
            if (Family != "A" && Family != "B" && Family != "C") return false;
            else return true;
        }

        private bool ValidateStartEndTime(byte StartHour, byte EndHour)
        {
            if ((StartHour > 11) || (EndHour > 11) || (StartHour >= EndHour)) return false;
            else return true;
        }

        public string CalculateTotalPay(string Family, byte StartHour, byte EndHour)
        {
            string TotalPay = "0.00 $";

            if (!ValidateFamilyIndex(Family))
            {
                return "Error: Incorrect family index!";
            }
            if (!ValidateStartEndTime(StartHour, EndHour))
            {
                return "Error: Invalid start or end hour!";
            }

            return TotalPay;
        }
    }
}
