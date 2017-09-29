using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Vehicle
    {
        string name;
        int speed;
        float distance;

        public Vehicle()
        {

        }
        public Vehicle(string name, int speed, float distance)
        {
            this.name = name;
            this.speed = speed;
            this.distance = distance;
        }

        public void showInformation()
        {
            Console.WriteLine("{0}的速度是{1}，行驶的路程为{2}", name, speed, distance);
        }

    }
}
