using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Reading.Read();
            int b = Reading.Read();

            Calculate.Plus(a, b);

            Calculate.Minus(a, b);

            Calculate.Multiply(a, b);

            Calculate.Divide(a, b);

        }
    }
}
