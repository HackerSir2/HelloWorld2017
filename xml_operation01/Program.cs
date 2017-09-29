using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_operation01
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建技能信息集合，用于存储所有的技能信息
            List<Skill> skillList = new List<Skill>();
            //XmlDocument 专门用来解析xml文档的
            XmlDocument xmlDoc = new XmlDocument();
            //通过文件名加载指定要加载的文件

            //xmlDoc.Load("skillInfo.txt");
            xmlDoc.LoadXml(File.ReadAllText("skillInfo.txt"));

            XmlNode rootNode = xmlDoc.FirstChild; //获取根节点
            XmlNodeList skillNodeList = rootNode.ChildNodes;//获取根节点下的所有节点skill

            //遍历skill下的所有节点，并将其存在fieldNodeList中 
            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();
                XmlNodeList fieldNodeList = skillNode.ChildNodes;
                foreach (XmlNode fieldNode in fieldNodeList)
                {
                    if (fieldNode.Name == "id")
                    {
                        //int id=Convert.ToInt32(fieldNode.InnerText);
                        int id = Int32.Parse(fieldNode.InnerText);
                        skill.Id = id;
                    }
                    else if (fieldNode.Name == "name")
                    {
                        string name = fieldNode.InnerText;
                        skill.Name = name;
                        skill.Lang = fieldNode.Attributes[0].Value;//获取name的属性值
                    }
                    else
                    {
                        int damage = Int32.Parse(fieldNode.InnerText);
                        skill.Damage = damage;
                    }
                }
                skillList.Add(skill);
            }
            foreach (Skill skil in skillList)
            {
                Console.WriteLine(skil.ToString());
            }

            Console.ReadKey();
        }
    }
}
