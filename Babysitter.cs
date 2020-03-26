using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babysitter
{
    public class BabySitter
    {
        byte[ , ] RateMatrix = new byte[3, 11] 
            {/* Time frame  5....6....7....8....9....10....11....12....1....2....3....4 */
             /* Family A */ { 15,  15,  15,  15,  15,   15,   20,   20,  20,  20,  20},
             /* Family B */ { 12,  12,  12,  12,  12,    8,    8,   16,  16,  16,  16},
             /* Family C */ { 21,  21,  21,  21,  15,   15,   15,   15,  15,  15,  15},
            };

        static void Main(string[] args)
        {
        }  
        
        private bool ValidateFamilyIndex(char Family)
        {
            if (Family != 'A' && Family != 'B' && Family != 'C') return false;
            else return true;
        }

        private bool ValidateStartEndTime(byte StartIdx, byte EndIdx)
        {
            if ((StartIdx > 11) || (EndIdx > 11) || (StartIdx >= EndIdx)) return false;
            else return true;
        }

        private int CalculatePayByFamilyAndRates(byte FamiliyIdx, byte StartIdx, byte EndIdx)
        {
            int TotalPayment = 0;
            byte RateIdx = StartIdx;

            while  (RateIdx < EndIdx) TotalPayment += RateMatrix[FamiliyIdx, RateIdx++];

            return TotalPayment;
        }

        private byte ConvertTimeToIndex(byte Time)
        {
            if (Time >= 5 && Time <= 12) return (byte)(Time - 5);
            else if (Time >= 1 && Time <= 4) return (byte)(Time + 7);
            else return 255;
        }

        public string CalculateTotalPay(char Family, byte StartHour, byte EndHour)
        {
            byte StartIdx = ConvertTimeToIndex(StartHour);
            byte EndIdx = ConvertTimeToIndex(EndHour);

            if (!ValidateFamilyIndex(Family))
            {
                return "Error: Incorrect family index!";
            }
            if (!ValidateStartEndTime(StartIdx, EndIdx))
            {
                return "Error: Invalid start or end hour!";
            }
            return CalculatePayByFamilyAndRates((byte)(Family - 'A'), StartIdx, EndIdx).ToString() + ".00 $";
        }
    }
}
