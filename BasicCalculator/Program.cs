using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal(5,"+",7) ;

        }

        static void Cal(int num1, string op, int num2)
        {
            int result = 0;

            switch (op)
            {
                case "-":
                    result = num1 - num2;
                    break;

                case "+":
                    result = num1 + num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Enter valid operatior");
                    break;
            }
            Console.WriteLine($"{num1} {op} {num2} = {result}");

        }
    }
}

