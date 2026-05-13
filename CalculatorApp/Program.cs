using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)//jxtydsh
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.add(1, 2));
        }
    }
}