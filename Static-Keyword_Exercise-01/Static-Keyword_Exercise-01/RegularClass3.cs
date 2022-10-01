using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword_Exercise_01
{
    internal class RegularClass3
    {
        public int _regularClassTotal;

        public RegularClass3()
        {
            StaticClass._regularClassesTotal++;
        }
    }
}

