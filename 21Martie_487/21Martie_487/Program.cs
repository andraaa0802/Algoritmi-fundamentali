using System;

namespace _21Martie_487
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0, C=0;
            float ma;
            n=int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] data=Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                suma += v[i];
            }
            ma = suma / n; ;
            for(int i = 0; i < n; i++)  
                if(v[i] > ma)   
                    C++;
            Console.WriteLine(C);
        }
    }
}
