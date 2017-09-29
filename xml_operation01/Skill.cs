using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_operation01
{
    class Skill
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Lang { set; get; }
        public int Damage { set; get; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Lang)}: {Lang}, {nameof(Damage)}: {Damage}";
        }
    }
}

