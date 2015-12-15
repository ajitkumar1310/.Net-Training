using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTypes
{
    partial class Abhinavclass
    {
        private int var1;
        private int var2;

        public int _var1
        {
            get
            {
                return var1;
            }
            set
            {
                var1 = value;
            }
        }
        public int _var2
        {
            get
            {
                return var2;
            }
            set
            {
                var2 = value;
            }
        }
    }
}
