using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
   sealed class MyTestAttribute:System.Attribute
   {
       public string Description { get; set; }
       public string VersionNumber { get; set; }
       public int ID { get; set; }

       public MyTestAttribute(int ID)
       {
            this.ID = ID; 
       }

   }
}
