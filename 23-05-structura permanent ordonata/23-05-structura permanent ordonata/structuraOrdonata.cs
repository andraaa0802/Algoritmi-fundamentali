using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_structura_permanent_ordonata
{
    internal class structuraOrdonata
    {
        int[] v;
        int size;
        public structuraOrdonata()
        {
            v = new int[0];
        }
        public void view()
        {
            foreach(int item in v)
                Console.WriteLine(item+" ");
        }
        public void Push (int n)
        {
            if (this.size == 0)
                this.v = emptyAdd(n);
            else if (n < this.v[0])
                this.v = addBeg(n);
            else if (n > this.v[size - 1])
                this.v = addEnd(n);
            else
                this.v = addMid(n);
            size++;
        }

        private int[] addMid(int n)
        {
            int[] newV=new int[size+1];
            int i = 0;
            while (n>this.v[i])
            {
                newV[i] = this.v[i];
                i++;
            }
            newV[i] = n;
            for (; i < size; i++)
                newV[i+1]=this.v[i];
            return newV;
        }

        private int[] addEnd(int n)
        {
            int[] newV = new int[size + 1];
            for (int i = 0; i < size; i++)
                newV[i] = this.v[i];
            newV[size] = n;
            return newV;
        }

        private int[] addBeg(int n)
        {
            int[] newV = new int[size + 1];
            newV[0] = n;
            for (int i = 0; i <size; i++)
                newV[i+1]=this.v[i];
            return newV;
        }

        private int[] emptyAdd(int n)
        {
            int[] newV = new int[1];
            newV[0] = n;
            return newV;
        }
        public int Pop()
        {
            int[] newV = new int[size-1];
            for (int i = 0; i < size-1; i++)
                newV[i]=this.v[i];
            this.size--;
            return this.v[size];
        }
    }
}
