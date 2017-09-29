using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String02
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "I am a blue cat";
            ////string res = Regex.Replace(s,"^","开始：");
            //string res = Regex.Replace(s,"$"," 结束;");
            //Console.WriteLine(res);
            //string strCheckNum1 = "23423423a3", strCheckNum2 = "324234";
            //Console.WriteLine("匹配字符串"+strCheckNum1+"是否为数字："+Regex.IsMatch(strCheckNum1,@"^\d*$"));
            //Console.WriteLine("匹配字符串"+strCheckNum2+"是否为数字："+Regex.IsMatch(strCheckNum2,@"^\d*$"));

            //string str = Console.ReadLine();
            //bool IsMatch = true;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i]<'0'||str[i]>'9')
            //    {
            //        IsMatch = false;
            //        break;
            //    }
            //}
            //string s = Console.ReadLine();
            //string s1 = @"www.baidu.com\n1kjsflkj";
            //string pattern = @"/d*";
            //bool IsMatch = Regex.IsMatch(s,pattern);
            //if (IsMatch)
            //{
            //    Console.WriteLine("输入的密码合法！");
            //}
            //else
            //{
            //    Console.WriteLine("输入的密码不合法！");
            //}
            //Console.WriteLine(s1);
            //Console.WriteLine(IsMatch);

            //string str =@"www.baidu.com\siki.takr";
            //string res = Regex.Replace(str, "\d", "###");
            //string strCheckNum1 = "23344345a3";
            //string strCheckNum2 = "3242343";

            string strCheckStr1 = "abcds_a";
            string strCheckStr2 = "**&&(((2";
            string strCheckStr3 = "**&&((((";
            string pattern = @"^\W*$"; //匹配规则

            string isQq1 = "1233", isQq2 = "a1233", isQq3 = "0123456", isQq4 = "556878554";

            //string pattern2 = @"^\d{5,12}$";

            //string findStr1 = "ad(d3)-df";
            //string regexFindStr = @"[a-z]|\d";//a字符到z字符或者数字字符
            //string newStrFind = String.Empty;

            //替换除了af以外的所有字符
            string str1 = "2342354klfljl_fsa;lf";
            string pattern3 = @"[^f]";
            string str2 = Regex.Replace(str1,pattern3,"abc");
            Console.WriteLine(str2);

            string strFind1 = "I am a Cat!", strFind2 = "My Name Blue cat";
            Console.WriteLine("除ahou这之外的所有字符，原字符为："+strFind1+"替换后："+Regex.Replace(strFind1,@"[^ahou]","*"));
            Console.WriteLine("除ahou这之外的所有字符，原字符为："+strFind2+"替换后："+Regex.Replace(strFind2,@"[^ahou]","*"));


            //获取指定字符串中的字母或者数字
            string findStr1 = "ad(d3)-df";
            string regexFindStr = @"[a-z]|\d";
            string newStrFind = String.Empty;
            MatchCollection newStr = Regex.Matches(findStr1,regexFindStr);  //将获取的的字符放在一个匹配项的集合内
            foreach (Match match  in newStr)
            {
                Console.WriteLine(match);                  
            }
            
            //将人名输出
            string strSplit = "zhangsan;lisi,wangwu.zhaoliu";
            //string regexSplitstr = @"[;,.]";
            string regexSplitstr = @"[;]|[,]|[.]";
            string[] strArray = Regex.Split(strSplit,regexSplitstr);
            foreach (string str in strArray)
            {
                Console.Write(str+" ");
            }
            Console.WriteLine();

            string TelNumber1 = "(010)87654321";
            string TelNumber2 = "010-87654321";
            string TelNumber3 = "01087654321";
            string TelNumber4 = "091287654321";
            string TelNumber5 = "010)87654321";
            string TelNumber6 = "(010-87654321";
            string TelNumber7 = "91287654321";
            Regex RegexTelNumber3 = new Regex(@"(\{0\d{2,3}\[-]?[7,8]|^0\d{2,3}[-]?\d{7,8}$})");

            Console.WriteLine("电话号码"+TelNumber1+"是否合法："+RegexTelNumber3.IsMatch(TelNumber1));
            Console.WriteLine("电话号码"+TelNumber2+"是否合法："+RegexTelNumber3.IsMatch(TelNumber2));
            Console.WriteLine("电话号码"+TelNumber3+"是否合法："+RegexTelNumber3.IsMatch(TelNumber3));
            Console.WriteLine("电话号码"+TelNumber4+"是否合法："+RegexTelNumber3.IsMatch(TelNumber4));
            Console.WriteLine("电话号码"+TelNumber5+"是否合法："+RegexTelNumber3.IsMatch(TelNumber5));
            Console.WriteLine("电话号码"+TelNumber6+"是否合法："+RegexTelNumber3.IsMatch(TelNumber6));
            Console.WriteLine("电话号码"+TelNumber7+"是否合法："+RegexTelNumber3.IsMatch(TelNumber7));

            
            Console.WriteLine("请输入任意一个字符串，测试分组：");
            string inputStr = Console.ReadLine();
            string strGroup1 = @"a{2}";


            //Console.WriteLine("单字符重复2次替换22，结果为："+Regex.Replace（inputStr,strGroup1,"22"));
            //MatchCollection newStr = Regex.Matches(findStr1, regexFindStr);
            //newStr.Cast<Match>().Select(m => m.Value).ToList<string>().foreach(i =>newStrFind += i);
            //Console.WriteLine(findStr1 + "中的字母和数字组成的新字符串为：" + newStrFind);


            //Console.WriteLine(isQq1+"是否为合法QQ号（5-12位数字）："+Regex.IsMatch(isQq1,pattern2));
            //Console.WriteLine(isQq2+"是否为合法QQ号（5-12位数字）："+Regex.IsMatch(isQq2,pattern2));
            //Console.WriteLine(isQq3+"是否为合法QQ号（5-12位数字）："+Regex.IsMatch(isQq3,pattern2));

            //Console.WriteLine("匹配字符" + strCheckNum1 + "是否为数字：" + Regex.IsMatch(strCheckNum1, @"^\d*$"));//从开始匹配多个数字字符一直到结束
            //Console.WriteLine("匹配字符" + strCheckNum2 + "是否为数字：" + Regex.IsMatch(strCheckNum2, @"^\d*$"));//从开始匹配多个数字字符一直到结束
            //string strCheckNum3 = Console.ReadLine();
            //Console.WriteLine("匹配字符" + strCheckNum3 + "是否为数字：" + Regex.IsMatch(strCheckNum3, @"^\d*$"));//从开始匹配多个数字字符一直到结束


            //Console.WriteLine($"匹配字符串" + strCheckStr1 + "是否为除大小写字母、0——9的数字、下划线_以外的任何字符：" + Regex.IsMatch(strCheckStr1, pattern));
            //Console.WriteLine($"匹配字符串" + strCheckStr2 + "是否为除大小写字母、0——9的数字、下划线_以外的任何字符：" + Regex.IsMatch(strCheckStr2, pattern));
            //Console.WriteLine($"匹配字符串" + strCheckStr3 + "是否为除大小写字母、0——9的数字、下划线_以外的任何字符：" + Regex.IsMatch(strCheckStr3, pattern));

            Console.ReadKey();
        }
    }
}
