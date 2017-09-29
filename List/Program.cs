using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scorelist = new List<int>();//创建一个空列表
            var scorelist1 = new  List<int>();
            
            var scoreList2 = new List<int>() { 1, 3, 5 };
            scoreList2.Add(7);
            Console.WriteLine(scoreList2.Count);
            Console.WriteLine(scoreList2[3]);

            Console.ReadKey();
        }
    }
}
