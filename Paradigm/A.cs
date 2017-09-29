using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigm
{
    class A<T,B>
    {
        private T x;
        private T y;
        private B z;

        public A(T x,T y) {
            this.x = x;
            this.y = y;
        }
        //public string GetSum()
        //{
        //    return x + "" + y;
        //}

        //public static void GetSum<T>() {
        //    Console.WriteLine("泛型");
        //}

    }
}
