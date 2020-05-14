using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" please enter number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" please enter number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(" please enter operation(-,+,/,*)");
            string op = Console.ReadLine();
                Cal(num1,op,num2);
            }
            catch
            {
                Console.WriteLine("inter valid number or operation");

            }


        }

        static void Cal(int num1, string op, int num2)
        {
            double result = 0;

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

