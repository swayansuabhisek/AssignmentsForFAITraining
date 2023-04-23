using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    //prime number or not ////////////////////////////////////////
    class Assignment7
    {
        static bool isPrimeNumber(int num)
        {
            // do stuff here
            if(num <= 1)
            {
                return false;
            }
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
#pragma warning disable CS0164 // This label has not been referenced
        RETRY:
#pragma warning restore CS0164 // This label has not been referenced
            try
            {
                int number = UserInterfaceConsole.GetNumber("Enter a number to check it is prime or not:");
                bool flag = isPrimeNumber(number);
                if (flag == true)
                {
                    Console.WriteLine($"{number} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number");
                }
                goto RETRY;
            }
            catch (FormatException)
            {
                Console.WriteLine("The entry should be a valid number in a numerc manner");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The number you enter should be in between the range of {int.MinValue} to {int.MaxValue}");
                goto RETRY;
            }
        }
    }
}
