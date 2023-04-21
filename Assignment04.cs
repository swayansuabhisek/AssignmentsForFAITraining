using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    class Assignment04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS equivalent data type for the array");
            string typeName = Console.ReadLine();
            Type selected = Type.GetType(typeName, false, true);

            if (selected == null)
            {
                Console.WriteLine("Invalid CTS type, not supported");
                return;
            }
            Array instance = Array.CreateInstance(selected, size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value for the index {0} of the datatype {1}", i, selected.Name);
                string input = Console.ReadLine();
                instance.SetValue(Convert.ChangeType(input, selected), i);
            }

            Console.WriteLine("Inputs are done , lets read the data");

            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }
        }
    }
}
