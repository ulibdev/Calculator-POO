using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculate
    {
        public static void Plus(int a, int b){

            Console.WriteLine("Plus:" + (a + b));

        }

        public static void Minus(int a, int b) { 

            Console.WriteLine("Minus:" + (a - b));

        }
        public static void Multiply(int a, int b) {

            Console.WriteLine("Multiply:" + (a * b));

        }

        public static void Divide(int a, int b) {

            try{

                Console.WriteLine("Divide:" + (a / b) );

            }
            catch(DivideByZeroException e)
            {

                Console.WriteLine("Error:" + e.Message);

            }
        }
    }
}
