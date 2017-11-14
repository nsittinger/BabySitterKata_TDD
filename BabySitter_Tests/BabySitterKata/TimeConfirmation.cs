using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    public class TimeConfirmation
    {
        //private int StartTime { get; set; }
        //private int BedTime { get; set; }
        //private int EndTime { get; set; }

        //public TimeConfirmation(int startTime, int bedTime, int endTime)
        //{
        //    StartTime = startTime;
        //    BedTime = bedTime;
        //    EndTime = endTime;
        //}
        
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

        public bool EndTimeIsAfterStartTime(int startTime, int endTime)
        {
            bool endTimeIsAfterStartTime = true;

            if((startTime <= 5 && endTime <= 5) || (startTime >= 17 && endTime >= 17))
            {
                if(startTime > endTime)
                {
                    endTimeIsAfterStartTime = false;
                }
            }
            else if (startTime <= 5 && endTime >= 17)
            {
                endTimeIsAfterStartTime = false;
            }

            return endTimeIsAfterStartTime;
        }

        public bool TimeConfirmationPass(int startTime, int bedTime, int endTime)
        {
            TimeConfirmation timeConfirmation = new TimeConfirmation();

            bool timeConfirmationPass = true;
            
            bool cannotWorkUntilFivePM = timeConfirmation.CannotWorkUntilFivePM(startTime);
            bool cannotWorkPastFourAM = timeConfirmation.CannotWorkPastFourAM(endTime);
            bool bedTimeIsAfterStartTime = timeConfirmation.BedTimeIsAfterStartTime(startTime, bedTime);
            bool endTimeIsAfterStartTime = timeConfirmation.EndTimeIsAfterStartTime(startTime, endTime);

            if (cannotWorkUntilFivePM != true || cannotWorkPastFourAM != true || bedTimeIsAfterStartTime != true || endTimeIsAfterStartTime != true)
            {
                timeConfirmationPass = false;
            }

            return timeConfirmationPass;
        }
    }
}
