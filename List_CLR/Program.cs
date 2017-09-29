using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_CLR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list= new List<string>();
            list.Add("7478");
            list.Add("465");
            list.Add("586");
            //list.Clear();
            Console.WriteLine(list.Count);

            Console.ReadKey();
        }
    }
}
