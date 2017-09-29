using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type只获取类的成员
            //MyClass my = new MyClass();
            //System.Type type = my.GetType();//获取对象所属类的Type类型
            //FieldInfo[]  array=type.GetFields();//获取当前System.Type中的所有字段
            //Console.WriteLine(type.Name); //获取类的名称
            //Console.WriteLine(type.Namespace);
            //Console.WriteLine(type.Assembly);
            ////Console.WriteLine(type.GetField("age"));
            //foreach (FieldInfo info in array)
            //{
            //    Console.Write(info.Name+' ');
            //}
            //PropertyInfo[] array1 = type.GetProperties(); //返回当前System.Type中的所有属性
            //foreach (PropertyInfo property in array1 )
            //{
            //    Console.WriteLine(property.Name+' ');
            //}
            ////获取所有的类方法
            //MethodInfo[] array2 = type.GetMethods();
            //foreach (MethodInfo info in array2)
            //{
            //    Console.Write(info.Name+" ");
               
            //}
            MyClass my = new MyClass();
            //Assembly a=my.GetType().Assembly;//通过类的type对象获它所在的程序集 Assembly
            //System.Type[] type=a.GetTypes(); //获取程序集中的所有的类
            //foreach (System.Type temp in type)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(a.FullName);
            Console.WriteLine(my.GetType());
            
            Console.ReadKey();
        }
    }
}
