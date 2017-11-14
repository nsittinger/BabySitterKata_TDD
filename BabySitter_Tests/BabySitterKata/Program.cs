using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeConfirmation timeConfirmation = new TimeConfirmation();
            Calculator calculator = new Calculator();
            CLI myCLI = new CLI(timeConfirmation, calculator);

            myCLI.Running();
        }
    }
}
