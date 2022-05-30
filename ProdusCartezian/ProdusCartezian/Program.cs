using System;

namespace ProdusCartezian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] s=new int[n+1];
            bool[] b=new bool[n+1];
            //BK1(0, n, s);
            //BK2(0, n, s);
            //BK3(0, n, s, b);
            //BK4(0, 7, s);
            BK5(0, n, s, b);
            Console.WriteLine("Done");
        }

        private static void BK5(int k, int n, int[] s, bool[] b)
        {//matrice care are aceeasi suma pe fiecare linie,coloana,diagonala; sl1=suma linie 1
            if(k>=n)
            {
                int sl1 = s[1] + s[2] + s[3];
                int sl2 = s[4] + s[5] + s[6];
                int sl3 = s[7] + s[8] + s[9];

                int sc1 = s[1] + s[4] + s[7];
                int sc2 = s[2] + s[5] + s[8];
                int sc3 = s[3] + s[6] + s[9];

                int sd1 = s[1] + s[5] + s[9];
                int sd2 = s[3] + s[5] + s[7];

                if(sl1==sl2 && sl2==sl3 && sl1==sc1 && sl1==sc2 && sl1==sc3 && sl1==sd1 && sl1==sd2)
                {
                    for (int i = 0; i < n; i++)
                        Console.Write(s[i]+" ");
                    Console.WriteLine();
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if(!b[i])
                {
                    b[i]=true;
                    s[k] = i;
                    BK5(k + 1, n, s, b);
                    b[i]=false;
                }
            }
        }

        private static void BK4(int k, int n, int[] s)
        {//se arunca 7 zaruri. sa se afiseze solutiile pt care exista cel putin 3 valori identice
            if(k>=n)
            {
                bool ok = false;
                int[]v=new int[7];
                for(int i=0; i<n; i++)
                {
                    v[s[i]]++;
                    if(v[s[i]]>=3)
                    {
                        ok = true;
                        break;
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(s[i]+" ");
                    }
                    Console.WriteLine();
                }
            }
            for (int i=1;i<=6;i++)
            {
                s[k] = i;
                BK4(k + 1, n, s);
            }
        }

        private static void BK1(int k, int n, int[] s)
        {//produs cartezian pt suma=15
            if(k>=n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                    sum += s[i];
                if (sum == 15)
                {
                    for (int i = 0; i < n; i++)
                        Console.Write(s[i] + " ");
                    Console.WriteLine();
                }
            }
            else
                for (int i = 0; i < 6; i++)
                {
                    s[k] = i;
                    BK1(k + 1, n, s);
                }
        }
       

        private static void BK2(int k, int n, int[] s)
        {//permutarile unei multimi (n^n)
            if(k>=n)
            {
                bool ok = true;
                for (int i = 0; i < n-1; i++)
                    for (int j = i+1; j < n; j++)
                        if(s[i]==s[j])
                        {
                            ok= false;
                            break;
                        }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                        Console.Write(s[i]+" ");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    s[k] = i + 1;
                    BK2(k + 1, n, s);
                }
            }
        }

        private static void BK3(int k, int n, int[] s, bool[] b)
        {//permutari (n!)
            if(k>=n)
            {
                for (int i = 0; i < n; i++)
                    Console.WriteLine(s[i]+" ");
                Console.WriteLine();
            }
            else
                for (int i = 0; i < n; i++)
                    if(!b[i])
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        BK3(k + 1, n, s, b);
                        b[i]=false;
                    }
        }
    }
}
