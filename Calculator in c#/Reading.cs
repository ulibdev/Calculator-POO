using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Reading { 
    
        public static int Read()
        {
            try
            {
                Console.WriteLine("i need a number:");

                string input = Console.ReadLine();

                int number = int.Parse(input);

                return number;

            }
            catch (FormatException) { 

                Read();

                return 0;

            }
        }
    }
}
