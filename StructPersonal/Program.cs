using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPersonal
{
    struct Personal
    {
        public string ID;
        public string sname;
        public string gender;
        public double ProgrammingResult;

        public void  InputInformation() {
            Console.WriteLine("姓名:{0}",sname);
            Console.WriteLine("学号:{0}",ID);
            Console.WriteLine("性别:{0}", gender);
            Console.WriteLine("程序设计成绩:{0}",ProgrammingResult);

        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personal personal1;
            personal1.ID = "20140202545";
            personal1.sname = "Mike";
            personal1.gender = "man";
            personal1.ProgrammingResult = 98;
            personal1.InputInformation();
        
            Console.ReadKey();

        }
    }
}
