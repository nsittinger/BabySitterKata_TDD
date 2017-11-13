using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    public class TimeConfirmation
    {
        public bool CannotWorkUntilFivePM(int startTime)
        {
            bool canWork = true;
            if(startTime < 17)
            {
                canWork = false;
            }
            return canWork;
        }

        public bool CannotWorkPastFourAM(int endTime)
        {
            bool canWork = true;
            if(endTime > 4 && endTime < 18)
            {
                canWork = false;
            }
            return canWork;
        }

        public bool BedTimeIsAfterStartTime(int startTime, int bedTime)
        {
            bool bedTimeIsAfterStartTime = true;
            if(bedTime < startTime)
            {
                bedTimeIsAfterStartTime = false;
            }
            return bedTimeIsAfterStartTime;
        }
    }
}
