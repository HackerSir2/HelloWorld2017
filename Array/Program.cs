using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array= new int[] {2,5,3,67,89,99,12};
            //int i = 0;
            //while (i<array.Length)
            //{
            //    Console.WriteLine(array[i]);
            //    i++;
            //}
            foreach (int temp in array)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
