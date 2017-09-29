using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace JsonOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Skill> skillList = new List<Skill>();
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("Json.txt"));
            //foreach (JsonData temp in jsonData)
            //{
            //    Skill skill = new Skill();
            //    JsonData idValue = temp["id"];
            //    JsonData nameValue = temp["name"];
            //    JsonData damageValue = temp["damage"];
            //    int id = Int32.Parse(idValue.ToString());
            //    int damage = Int32.Parse(damageValue.ToString());
            //    //Console.WriteLine(id + ":" + nameValue.ToString() + damage);
            //    skill.idValue = id;
            //    skill.nameValue = nameValue.ToString();
            //    skill.damageValue = damage;
            //    skillList.Add(skill);
            //}
            //foreach (Skill temp in skillList)
            //{
            //    Console.WriteLine(temp.ToString());
            //}
            //Skill [] skillArray = JsonMapper.ToObject<Skill[]>(File.ReadAllText("Json.txt"));
            //List <Skill> skillArray = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("Json.txt"));
            //foreach (Skill temp in skillArray)
            //{
            //    Console.WriteLine(temp);
            //}
            Player p = JsonMapper.ToObject<Player>(File.ReadAllText("PlayerInformation.txt"));
            Console.WriteLine(p);
            foreach (Skill temp in p.skillList)
            {
                Console.WriteLine(temp);
            }

            Player p1 = new Player();
            p1.Name = "Mark";
            p1.Gender =21;
            p1.Level = 5;
            string json=JsonMapper.ToJson(p1);
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
