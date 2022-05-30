using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class tridata
    {
        int l, c, v;
        public tridata(int l, int c, int v)
        {
            this.l = l;
            this.c = c; 
            this.v = v;
        }
        public void view()
        {
            Console.Write("("+l + ", " + c + ", " + v+")");
        }

    }
}
