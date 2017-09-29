using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperation
{
    class Player
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public List<Skill> skillList { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Gender)}: {Gender}, {nameof(Level)}: {Level}, {nameof(skillList)}: {skillList}";
        }
    }
}
