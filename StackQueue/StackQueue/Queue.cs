using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Queue
    {
        tridata[] val;
        int n;
        public Queue()
        {
            val= new tridata[0];
        }
        
        public void Push (tridata v)
        {
            tridata[] T=new tridata[val.Length+1];
            for (int i = 0; i <val.Length; i++)
            {
                T[i+1] = val[i];
            }
            T[0] = v;
            val = T;
        }
        public tridata Pop ()
        {
            tridata toR=val[val.Length-1];
            tridata[] T = new tridata[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
                T[i] = val[i];
            val= T;
            return toR;
        }
        public void view()
        {
            for (int i=0;i<val.Length;i++)
                val[i].view();
        }
    }
}
