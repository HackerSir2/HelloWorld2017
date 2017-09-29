using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;
namespace ParamsArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int s1 = sum(new int [] {12,25,6,7,14,125});
            int s2 = Plus(/*23, 14, 35, 45, 68, 21*/12, 25, 6, 7, 14, 125);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            var m = "jslsls";
            var v= new Vehicle("OD",60,234);
            v.showInformation();


            Console.ReadKey();
        }

        static int Plus(params int [] array) {
            int sum = 0;
            for (int i = 0; i <array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int sum(int [] array) {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
