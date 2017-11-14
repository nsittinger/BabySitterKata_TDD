using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    class CLI
    {
        private TimeConfirmation TimeConfirmation { get; set; }
        private Calculator Calculator { get; set; }

        public CLI(TimeConfirmation timeConfirmation, Calculator calculator)
        {
            this.TimeConfirmation = timeConfirmation;
            this.Calculator = calculator;
        }

        public void Running()
        {
            bool running = true;
            while (running)
            {
                running = GetStartTime();
            }
            Environment.Exit(0);
        }
                
        public bool GetStartTime()
        {
            bool running = true;

            Console.WriteLine("What time did you start?");
            int startTime = Convert.ToInt32(Console.ReadLine());
            
            while (running)
            {
                running = GetBedTime(startTime);
            }

            return running;
        }

        public bool GetBedTime(int startTime)
        {
            bool running = true;

            Console.WriteLine("When was bed time?");
            int bedTime = Convert.ToInt32(Console.ReadLine());

            while (running)
            {
                running = GetEndTime(startTime, bedTime);
            }

            return running;
        }

        public bool GetEndTime(int startTime, int bedTime)
        {
            bool running = true;

            Console.WriteLine("What time did you leave?");
            int endTime = Convert.ToInt32(Console.ReadLine());

            while (running)
            {
                running = TimeConfirmationPassAndDisplayTotalPayOut(startTime, bedTime, endTime);
            }

            return running;
        }

        public bool TimeConfirmationPassAndDisplayTotalPayOut(int startTime, int bedTime, int endTime)
        {
            bool running = true;
            bool timeConfirmationPass = TimeConfirmation.TimeConfirmationPass(startTime, bedTime, endTime);

            if(timeConfirmationPass)
            {
                double totalPayOut = Calculator.TotalPayOut(startTime, bedTime, endTime);
                Console.WriteLine("Your pay for the night is $" + totalPayOut);
                Console.ReadLine();
                while (running)
                {
                    running = RepeatMenu();
                }
            }
            else
            {
                Console.WriteLine("Time inputs are incorrect");
                Console.ReadLine();
                while (running)
                {
                    running = RepeatMenu();
                }
            }

            return running;
        }

        public bool RepeatMenu()
        {
            bool running = true;

            Console.WriteLine("Repeat calculation? (y/n)");
            string input = Console.ReadLine().ToLower();

            if(input == "y")
            {
                running = GetStartTime();
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            return running;
        }
    }
}
