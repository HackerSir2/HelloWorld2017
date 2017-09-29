using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new List<MartialArtsMaster>()
            {
    new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
    new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu  = "打狗棒法",  Level = 10 },
    new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
    new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu= "葵花宝典",  Level = 1  },
    new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
    new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
    new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
    new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
    new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
    new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
    new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
            };


            //初始化武学
            var kongfuList = new List<Kongfu>(){

    new Kongfu(){Id=1, Name="打狗棒法",Power=90},
    new Kongfu(){Id=2, Name="降龙十八掌", Power=95},
    new Kongfu(){Id=3, Name="葵花宝典", Power=100},
    new Kongfu() { Id=  4, Name= "独孤九剑", Power = 100 },
    new Kongfu() { Id = 5, Name= "九阴真经", Power = 100 },
    new Kongfu() { Id = 6, Name= "弹指神通", Power = 100 }

};
            //    //创建一个线性表用于存放master.Level>90的master
            //    var res = new List<MartialArtsMaster>();
            //    foreach (MartialArtsMaster temp in masterList)
            //    {
            //        if (temp.Level > 8)
            //        {
            //            res.Add(temp);
            //        }

            //    }
            //    //使用LINQ语句查询
            //    var res1 = from m in masterList
            //               where m.Level > 8
            //               select m;

            //    //masterList.SelectMany<>()
            //    //{

            //    //};

            //    //联合查询
            //    var res6 = from m in masterList
            //               join n in kongfuList on m.Kongfu equals n.Name
            //               where n.Power <= 95
            //               orderby m.Age descending
            //               select new { master = m, kongfu = n
            //               };

            //    //分组查询（into groups）
            //    var res7 = from k in kongfuList
            //               join m in masterList on k.Name equals m.Kongfu
            //               into groups
            //               //descending（递减）降序排列
            //               orderby groups.Count() descending
            //               select new { Kung = k.Name, count = groups.Count() };


            //    var re1 = from m in masterList
            //              where m.Age > 30
            //              select m;

            //    //按照自身字段进行分组 group by
            //    var res8 = from m in masterList
            //               group m by m.Kongfu into g
            //               orderby g.Count() descending
            //               select new {count=g.Count(), //每个门派有的人数n
            //               key=g.Key   //g.Key表示当前分组按照哪个属性进行分组
            //};
            //    //量词操作符，any all判断集合中是否满足某个条件
            //    //Any方法用于判断集合中是否有满足条件的对象，返回一个bool类型的值(有一个满足条件就为True)
            //    var res9=masterList.Any(m => m.Menpai == "长留");
            //    Console.WriteLine(res9);

            //    //判断集合中的对象是否都满足某个条件
            //   var res10= masterList.All(m=> m.Menpai=="华山");
            //    Console.WriteLine(res10);

            //    //    
            //    //遍历
            //    foreach (var temp in res7)
            //    {
            //        Console.WriteLine(temp);
            //    }

            //查询丐帮中，修行“级别”高于“8级”的大侠
            //var GaiBangMaster = from m in masterList
            //    where m.Level > 8 && m.Menpai == "丐帮"
            //    select m;
            //foreach (var temp in GaiBangMaster)
            //{
            //    Console.WriteLine(temp);
            //}

            var GaiBangMasterMethod = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");

            //foreach (var temp in GaiBangMasterMethod)
            //{
            //    Console.WriteLine(temp);
            //}
            string GaiBangMasterMethodResult=null;
            foreach (var m in GaiBangMasterMethod)
            {
                GaiBangMasterMethodResult += m.Id + " " + m.Name + " " + m.Menpai + " " + m.Level + " " + m.Kongfu + " "+"\n";
                Console.WriteLine(GaiBangMasterMethodResult);
            }

            ////使用LINQ语句联合查询：查询所学功夫杀伤力大于90的武林高手
            //var res2 = from j in masterList
            //           from k in kongfuList
            //           where j.Kongfu == k.Name && k.Power > 90

            //           //取得两个字段j,k;
            //           select new
            //           {
            //               master = j,
            //               kongfu = k
            //           };
            ////select j;

            ////使用LINQ语句进行单表排序查询
            ////var res3 = from p in masterList
            ////           where p.Menpai == "丐帮" 
            ////           orderby p.Level ,p.Age 
            ////           select p;

            ////先按字段Level排序，Level相同，再按字段Age排序。
            //var res3 = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Level).ThenByDescending(m => m.Age);

            ////join on联合查询
            //var res4 = from m in masterList
            //           join k in kongfuList on m.Kongfu equals k.Name
            //           orderby m.Age
            //           select new { master = m, Kongfu = k };


            //foreach (var temp in res4)
            //{
            //    Console.WriteLine(temp);
            //}

            Console.ReadKey();

        }
    }
}
