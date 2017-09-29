using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm
{
    class Program
    {
        public static string GetSum<T,T1,T2,T4>(T x,T y) {
            return x + "" + y;
        }

        static void CommonSort<T>(T[] sortArray,Func<T,T,bool> CompareMethod)
        {
            bool swaped = true;

            do
            {
                swaped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (CompareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swaped = true;
                    }
                }
            } while (swaped);

        }

        static void Main(string[] args)
        {
            //A<int> a = new A<int>(3,56);
            var a = new A<int,string>(3,423);  
            Console.WriteLine(GetSum<char,char,int,string>('a','c'));
            Employee[] employee = new Employee[] {new Employee("zhangsan",223),new Employee("Lisi",122),new Employee("wangwu",434),new Employee("zhaosi",65)};
            CommonSort<Employee>(employee,Employee.Compare);
            foreach (var em in employee)
            {
                Console.WriteLine(em.ToString());
            }

            Console.ReadKey();
        }
    }
}
