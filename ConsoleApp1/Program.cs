using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { null, "asd", "adf", null, null, "qwe", null, null, null };
            string[] array2 = new string[] { "1", "2", "3" };

            Arrays.RandomArrayFilling(array1, array2);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(i + " " + array1[i]);
            }
        }      
    }
}

