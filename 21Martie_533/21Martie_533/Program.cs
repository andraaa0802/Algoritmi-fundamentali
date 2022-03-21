using System;

namespace _21Martie_533
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imin=-1, imax=-1, n, i, minim, maxim;
            n=int.Parse(Console.ReadLine());   
            string[]data=Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for(i=0;i<n;i++)
                v[i]=int.Parse(data[i]);
            minim = v[0];
            maxim = v[0];
            for(i=1;i<n;i++)
            {
                if(v[i]<minim)
                {
                    minim = v[i];
                    imin = i;
                }
                if (v[i]>maxim)
                {
                    maxim = v[i];
                    imax = i;
                }
            }
            Console.WriteLine((imin+1) + " " + (imax+1));
        }
    }
}
