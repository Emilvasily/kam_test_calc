using Calculator.Core;
using Calculator.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcOperation calc = new CalcOperation();
            calc.Before = 20;
            calc.Operation = SimpleOperation.Multiply;
            calc.Before = 2;
            Console.WriteLine(calc.After);
            calc.Operation = SimpleOperation.Addition;
            calc.Before = 2;
            Console.WriteLine(calc.After);
            calc.Operation = SimpleOperation.Divide;
            calc.Before = 3;
            Console.WriteLine(calc.After);
            calc.Operation = SimpleOperation.Substraction;
            calc.Before = 4;
            Console.WriteLine(calc.After);
            calc.Operation = SimpleOperation.Square;
            calc.Before = 2;
            Console.WriteLine(calc.After);



            Console.ReadLine();
        }
    }
}
