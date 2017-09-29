using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Ennemy
    {
        public float x;
        public float y;
        public float z;
    }

    enum Direction
    {
        West,
        South,
        East,
        North
    }

    struct path
    {
        public Direction dir;
        public float distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ennemy ennemy1;
            ennemy1.x = 12;
            ennemy1.y = 34;
            ennemy1.z = 9;



        }
    }
}
