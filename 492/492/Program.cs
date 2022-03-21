using System;

namespace _492
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,perechi=0;
            n=int.Parse(Console.ReadLine());
            int []v=new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);
            for (int i=0;i<n/2;i++)
                if (cmmdc(v[i],v[n-i-1])==1)
                    perechi++;
            Console.WriteLine(perechi);
        }

        static int cmmdc (int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                if (b > a)
                    b -= a;
            }
            return a;   
        }
    }
}
