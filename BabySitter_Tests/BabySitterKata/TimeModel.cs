using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    public class TimeModel
    {
        public string Input { get; set; }
        public int Time { get; set; }

        public static List<string> timeInputs { get; } = new List<string>()
        {
            { "1:00 AM" },
            { "2:00 AM" },
            { "3:00 AM" },
            { "4:00 AM" },
            { "5:00 AM" },
            { "6:00 AM" },
            { "7:00 AM" },
            { "8:00 AM" },
            { "9:00 AM" },
            { "10:00 AM" },
            { "11:00 AM" },
            { "12:00 PM" },
            { "1:00 PM" },
            { "2:00 PM" },
            { "3:00 PM" },
            { "4:00 PM" },
            { "5:00 PM" },
            { "6:00 PM" },
            { "7:00 PM" },
            { "8:00 PM" },
            { "9:00 PM" },
            { "10:00 PM" },
            { "11:00 PM" },
            { "12:00 AM" }
        };

        public int Switch(string input)
        {
            int time = 0;

            switch(input) 
            {
                case "1:00 AM":
                    time = 1;
                    break;
                case "2:00 AM":
                    time = 2;
                    break;
                case "3:00 AM":
                    time = 3;
                    break;
                case "4:00 AM":
                    time = 4;
                    break;
                case "5:00 AM":
                    time = 5;
                    break;
                case "6:00 AM":
                    time = 6;
                    break;
                case "7:00 AM":
                    time = 7;
                    break;
                case "8:00 AM":
                    time = 8;
                    break;
                case "9:00 AM":
                    time = 9;
                    break;
                case "10:00 AM":
                    time = 10;
                    break;
                case "11:00 AM":
                    time = 11;
                    break;
                case "12:00 PM":
                    time = 12;
                    break;
                case "1:00 PM":
                    time = 13;
                    break;
                case "2:00 PM":
                    time = 14;
                    break;
                case "3:00 PM":
                    time = 15;
                    break;
                case "4:00 PM":
                    time = 16;
                    break;
                case "5:00 PM":
                    time = 17;
                    break;
                case "6:00 PM":
                    time = 18;
                    break;
                case "7:00 PM":
                    time = 19;
                    break;
                case "8:00 PM":
                    time = 20;
                    break;
                case "9:00 PM":
                    time = 21;
                    break;
                case "10:00 PM":
                    time = 22;
                    break;
                case "11:00 PM":
                    time = 23;
                    break;
                case "12:00 AM":
                    time = 24;
                    break;
            }

            return time;
        }
    }
}
