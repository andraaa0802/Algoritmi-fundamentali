using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Stack
    {
        public int[] val;
        public int idx;
        public int max_stack = 5;
        public Stack()
        {
            val = new int[max_stack];
            idx = 0;
        }
        public void Push(int v)
        {
            if (idx<val.Length)
            {
                val[idx] = v;
                idx++;
            }
            else
            {
                int[] tmp=new int[val.Length+max_stack];
                for (int i=0;i<val.Length;i++)
                    tmp[i] = val[i];
                val = tmp;
                val[idx] = v;
                idx++;
            }
        }
        public int Pop()
        {
            int toR = val[0];
            int[] T=new int[val.Length-1];
            for (int i = 0; i < val.Length-1; i++)
            {
                T[i] = val[i + 1];
            }
            val = T;
            return toR;
        }
        public void View()
        {
            for (int i = 0; i < val.Length; i++)
                Console.Write(val[i] + " ");
        }
    }
}
