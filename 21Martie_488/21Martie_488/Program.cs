using System;

namespace _21Martie_488
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            int n, i;
            n = int.Parse(Console.ReadLine());
            v=new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for(i=0;i<n;i++)
                v[i]=int.Parse(data[i]);
            for (i = 1; i < n; i += 2)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            if (n % 2 == 0)
                for (i = n - 2; i >= 0; i -= 2)
                    Console.Write(v[i] + " ");
            else
                for (i = n - 1; i >= 0; i -= 2)
                    Console.Write(v[i] + " ");

        }
    }
}
