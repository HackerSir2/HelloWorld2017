﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass(1,2);

            Console.ReadKey();
        }
    }
}
