using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = EnterNumber1();
            char operation = EnterOperator();
            int b = EnterNumber2();

            Calculation calc = new Calculation();

            switch (operation)
            {
                case '+':
                    PrintResult(calc.Sum(a, b).ToString());
                    break;
                case '-':
                    PrintResult(calc.Diff(a, b).ToString());
                    break;
                case '*':
                    PrintResult(calc.Multiply(a, b).ToString());
                    break;
                case '/':
                    try
                    {
                        PrintResult(calc.Division(a, b).ToString());

                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divide by zero");
                    }
                    break;
            }
            Console.ReadKey();
        }

        static int EnterNumber1()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                int num1;
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    return num1;

                }

            }

        }
        static char EnterOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator:");
                char oper = Console.ReadLine()[0];
                if (oper == '+' | oper == '-' | oper == '*' | oper == '/')
                    return oper;

                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    continue;
                }
            }
        }
        static int EnterNumber2()
        {
            while (true)
            {

                Console.WriteLine("Enter second number:");
                int num2;
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    return num2;
                }
            }
        }
        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
