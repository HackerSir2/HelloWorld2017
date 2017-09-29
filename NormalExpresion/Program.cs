using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NormalExpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex reg = new Regex("a[^123456]");
            //Console.WriteLine(reg.Match("a1a2a3a4a5a6a7"));

            //.匹配任意字符的字符数组
            Regex reg = new Regex(".c");
            //|多选分支 选择两者中的一个。
            Regex reg1 = new Regex("abc|def");
            Regex reg2 = new Regex("Abc");
            Console.WriteLine("请输入一个任意字符串，测试分组：");
            string inputStr = Console.ReadLine();
            //string strGroup1 = @"a{2}";
            //Console.WriteLine("单字符重复两次替换为22，结果为："+Regex.Replace(inputStr,strGroup1,"22"));
            //重复多个字符使用（abcd）{n}进行分组限定
            string strGroup2 = @"(ab\w{2}){2}";
            Console.WriteLine("分组字符重复两次替换为555，结果为：" + Regex.Replace(inputStr, strGroup2, "555"));

            //校验IP4地址
            string regexStrIP4 = @"(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$";
            Console.WriteLine("请输入一个IP4地址：");
            string inputStrIP4 = Console.ReadLine();
            Console.WriteLine(inputStrIP4+"是否为合法的IP4地址："+Regex.IsMatch(inputStrIP4,regexStrIP4))
            ;
            
            //Console.WriteLine(reg.Match("bcdefg"));
            //Console.WriteLine(reg1.Match("bcdefg"));
            //Console.WriteLine(reg2.Match("abcdefg"));

            Console.ReadKey();
        }
    }
}
