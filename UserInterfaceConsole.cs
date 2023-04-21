using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    class UserInterfaceConsole
    {
        internal static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }
        internal static double GetDouble(string question)
        {
            return double.Parse(GetString(question));
        }
        internal static long GetLong(string question)
        {
            return long.Parse(GetString(question));
        }
        internal static DateTime GetDate(string question)
        {
            Console.WriteLine(question);
            Console.WriteLine("Enter the date as MM/DD/YYYY");
            return DateTime.Parse(Console.ReadLine());
        }

        internal static void PrintMessage(string v)
        {
            var fgcolor = Console.ForegroundColor;
            var bgcolor = Console.BackgroundColor;


            Console.WriteLine(v);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.ForegroundColor = fgcolor;
            Console.BackgroundColor = bgcolor;

        }
    }
}
