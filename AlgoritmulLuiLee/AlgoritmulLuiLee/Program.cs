using System;
using System.IO;
namespace AlgoritmulLuiLee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            string[] t=load.ReadLine().Split(' ');
            int n=int.Parse(t[0]);
            int m=int.Parse(t[1]);
            int[,] a = new int[n, m];
            for(int i=0; i<n; i++)
            {
                string[] buffer = load.ReadLine().Split(' ');
                for(int j=0; j<m; j++)
                    a[i,j] = int.Parse(buffer[j]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
       
    }
}
