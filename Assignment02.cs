using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            
            int n = UserInterfaceConsole.GetNumber("Enter the array size");
            Console.WriteLine("Enter the numbers");
            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even numbers");
            for(int i =0;i<arr.Length;i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers");
            for(int i =0;i<arr.Length;i++)
            {
                if ((arr[i] % 2) != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
