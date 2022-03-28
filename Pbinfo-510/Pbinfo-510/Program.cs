using System;

namespace Pbinfo_510
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,nr_prime=0;
            n=int.Parse(Console.ReadLine());
            int[]v=new int[n];
            int[] prime = new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(data[i]);
                if(prim(v[i])==true)
                {
                    prime[nr_prime]=v[i];  
                    nr_prime++;
                }
            }
            if (nr_prime!=0)
            {
                bool ok;
                int aux, k = 0;
                do
                {
                    ok = true;
                    for (int i = 0; i < nr_prime - 1 - k; i++)
                    {
                        if (prime[i] > prime[i + 1])
                        {
                            aux = prime[i];
                            prime[i] = prime[i + 1];
                            prime[i + 1] = aux;
                            ok = false;
                        }
                    }
                    k++;
                } while (!ok);
                for (int i = 0; i < nr_prime; i++)
                    Console.Write(prime[i] + " ");
            }
            

        }

        private static bool prim(int v)
        {
            if(v<2) return false;
            else if(v==2) return true;
            else if (v%2==0) return false;
            else
            {
                for (int i = 3; i * i <= v; i += 2)
                    if (v % i == 0) return false;
            }
            return true;
        }
    }
}
