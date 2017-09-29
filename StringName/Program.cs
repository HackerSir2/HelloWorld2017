using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringName
{
    struct Information
    {
        public string name;
        public int age;
        public string gender;
        //public string ID;
        public string className;
        public int height;
        public int weight;

        public void showInformation()
        {
            Console.WriteLine("{0}今年{1}岁，体重{2}千克，是艺术学院{3}班的学生", name, age, weight, className);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Information P;
            P.height = 165;
            P.gender = "female";
            P.name = "刘美彤";
            P.age = 18;
            P.weight = 50;
            P.className = "A1443";
            P.showInformation();

            Console.ReadKey();
        }
    }
}
