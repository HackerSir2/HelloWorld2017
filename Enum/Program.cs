using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum GameState {
        Start,
        Pause,
        Faile,
        Success
    }
    class Program
    {
        static void Main(string[] args)
        {
            //GameState state = GameState.Start;
            //if (state==GameState.Start)
            //{
            //    Console.WriteLine("游戏加载中......");
            //}
            string str = Console.ReadLine();
            switch (str) {
                case "Start":
                    Console.WriteLine("游戏加载中.......");
                    break;
                case "Pause":
                    Console.WriteLine("暂停游戏.......");
                    break;
                case "Faile":
                    Console.WriteLine("游戏结束.......");
                    break;
                case "Success":
                    Console.WriteLine("恭喜你，你赢了！");
                    break;
                default:
                    Console.WriteLine("输入数据不合法！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
