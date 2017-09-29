using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperation
{
    class Skill
    {
        public int id { set; get; }
        public string name { set; get; }
        public int damage { set; get; }

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(name)}: {name}, {nameof(damage)}: {damage}";
        }
    }
}
