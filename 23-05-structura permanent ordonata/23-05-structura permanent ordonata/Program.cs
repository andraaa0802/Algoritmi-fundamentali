using System;

namespace _23_05_structura_permanent_ordonata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            structuraOrdonata a= new structuraOrdonata();
            
            a.Push(2);
            a.Push(3);
            a.Push(1);
            a.Push(123);
            a.Push(83);
            a.Push(182);
            a.Push(0);
            a.Push(876);
            a.view();
        }
    }
}
