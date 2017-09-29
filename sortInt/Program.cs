using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortInt
{
    class Program
    {
        static void  sortInt(int[] sortArray)
        {
            bool swaped = true;

            do
            {
                swaped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swaped = true;
                    }
                }
            } while (swaped);

        }

        static void Main(string[] args)
        {
            int[] array = new int[] {12,45,3,10,2,435};
            sortInt(array);
            foreach (var temp in array)
            {
                Console.Write(temp+" ");
            }

            Console.ReadKey();
        }

    }
}
