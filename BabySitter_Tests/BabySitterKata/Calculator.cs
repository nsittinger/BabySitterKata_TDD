using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    public class Calculator
    {
        public double StartToBedTimePay(int startTime, int bedTime)
        {
            int hoursFromStartToBed = bedTime - startTime;
            double startToBedPay = hoursFromStartToBed * 12.00;

            return startToBedPay;
        }

        public double BedTimeToMidnightPay(int bedTime)
        {
            int hoursFromBedToMidnight = 24 - bedTime;
            double bedTimeToMidnightPay = hoursFromBedToMidnight * 8.00;

            return bedTimeToMidnightPay;
        }
    }
}
