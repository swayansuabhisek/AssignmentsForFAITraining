using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    enum weekDays : Byte
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thusday,
        Friday,
        Saturday
    }
    class Assignment01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of a week");
            Array Days = Enum.GetValues(typeof(weekDays));

            for (int i = 0; i < Days.Length; i++)
            {
                Console.WriteLine(Days.GetValue(i));
            }
            Console.WriteLine("Enter the day you want to come to office");
            string input = Console.ReadLine();
            object selectedDay = Enum.Parse(typeof(weekDays), input, true);
            //object selectedType = Enum.Parse(typeof(AccountType), Console.ReadLine() ,true);
            weekDays selected = (weekDays)selectedDay;
            Console.WriteLine("I want to come to office on " + selected);
        }
    }
}
