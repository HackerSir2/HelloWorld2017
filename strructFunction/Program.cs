using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strructFunction
{
    struct CustomerName {
        public string FirstName;
        public string LastName;

        public void getName()
        {
            Console.WriteLine("My name is:"+FirstName +" "+LastName);
        }

    }

    struct Vector3 {
        public float x;
        public float y;
        public float z;

        public double Distance() {
            return Math.Sqrt(x * x + y * y + z * z);

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomerName myName;
            myName.FirstName = "siki";
            myName.LastName = "liang";
            myName.getName();

            Vector3 myVector3;
            myVector3.x = 1.0f;
            myVector3.y = 2.0f;
            myVector3.z = 3.0f;
            double d = myVector3.Distance();
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
