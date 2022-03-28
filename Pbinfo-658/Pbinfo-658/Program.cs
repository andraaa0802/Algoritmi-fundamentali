using System;

namespace Pbinfo_658
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linie=Console.ReadLine().Split(' ');
            int n, m;
            n=int.Parse(linie[0]);
            m=int.Parse(linie[1]);
            int[,] matrix=new int[n,m];
            string[] buffer;
            for(int i=0; i<n; i++)
            {
                buffer=Console.ReadLine().Split(' ');
                for(int j=0; j<m; j++)
                    matrix[i,j]=int.Parse(buffer[j]); 
            }    
            for(int i=0; i<n; i++)
            {
                int suma = 0;
                for(int j=0;j<m;j++)
                    suma+=matrix[i,j];
                Console.Write(suma+" ");
            }
        }
    }
}
