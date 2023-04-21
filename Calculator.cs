using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Calculator
    {
        enum Operation : byte
        {
            Addition, Substraction, Multiplication, Division, Square, Squareroot
        }

       
        private static double calculator(double first, double second, string choice)
        {
            double result = 0;
            switch (choice)
            {
                case "Addition": result = first + second; break;
                case "Substraction": result = first - second; break;
                case "Multiplication": result = first * second; break;
                case "Division": result = first / second; break;
                default:
                    break;
            }
            return result;
        }
        private static double calculator2(double num, string choice)
        {
            double result = 1;
            switch (choice)
            {
                case "Square": result = num * num; break;
                case "Squareroot": result = Math.Sqrt(num); break;

                default:
                    break;
            }
            return result;
        }
         
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Which operation do you want:");
                Array possibleValues = Enum.GetValues(typeof(Operation));

                for (int i = 0; i < possibleValues.Length; i++)
                {
                    Console.WriteLine(possibleValues.GetValue(i));
                }
                string input = Console.ReadLine();
                object selectedType = Enum.Parse(typeof(Operation), input, true);

                Operation ans = (Operation)selectedType;

                string compare = ans.ToString();

                if (compare == "Addition" || compare == "Substraction" || compare == "Multiplication" || compare == "Division")
                {
                    double first = UserInterfaceConsole.GetDouble("Enter the first number");
                    double second = UserInterfaceConsole.GetDouble("Enter the second number");

                    double result = calculator(first, second, compare);
                    Console.WriteLine(result);
                }

                if(compare == "Square" || compare == "Squareroot")
                {
                    double num = UserInterfaceConsole.GetDouble("Enter the a number");


                    double result2 = calculator2(num, compare);
                    Console.WriteLine(result2);
                }

                //switch()


                Console.WriteLine("Do you want to continue y/n :");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Enter)
                {
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    return;
                }

            } while (true);
        }
    }
}
