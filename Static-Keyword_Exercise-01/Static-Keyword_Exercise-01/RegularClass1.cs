using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword_Exercise_01
{
    internal class RegularClass1
    {
        public int _regularClassTotal;
        
        public RegularClass1()
        {
            StaticClass._regularClassesTotal++;
        }
    }
}
