using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    class Assignment6
    {
        static bool leapYear(int year)
        {
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }
        static bool isValidDate(int year, int month, int day)
        {
            // do stuff here

            if(month >12 || month < 1)
            {
                return false;
            }
            else if (month == 2 || month == 02)
            {
                if(leapYear(year))
                {
                    if (day>29 || day<1)
                    {
                        return false;
                    }
                }
                else
                {
                    if (day > 28 || day < 1)
                    {
                        return  false;
                    }
                }
            }
            else if (month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12)
            {
                if (day > 31 || day < 1)
                {
                    return false;
                }
            }
            else if (month == 04 || month == 06 || month == 09 || month == 11)
            {
                if (day > 30 || day < 0)
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            try
            {
            RETRY:
                int year = UserInterfaceConsole.GetNumber("Enter the year");
                int month = UserInterfaceConsole.GetNumber("Enter the month");
                int day = UserInterfaceConsole.GetNumber("Enter the day");
                bool check = isValidDate(year, month, day);
                if (check)
                {
                    Console.WriteLine("The date is VALID");
                    Console.WriteLine("Press any key to clear:");
                    Console.ReadKey();
                    Console.Clear();
                    goto RETRY;
                }
                else
                {
                    Console.WriteLine("The date is INVALID");
                    Console.WriteLine("Press any key to clear:");
                    Console.ReadKey();
                    Console.Clear();
                    goto RETRY;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the valid format");
            }
        }
    }
}
