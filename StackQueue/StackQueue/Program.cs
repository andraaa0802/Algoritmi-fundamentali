using System;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue A = new Queue();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.View();

            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.View();*/

            Stack B = new Stack();

            string S = "1 2 +";
            string[] d = S.Split(' ');
            int t;
            for (int i = 0; i < d.Length; i++)
            {
                if ((d[i])[0] >= '0' && (d[i])[0] <= '9')
                {
                    t = int.Parse(d[i]);
                    Console.Write(t + " ");
                    B.Push(t);
                }
                else
                {
                    int t1 = B.Pop();
                    int t2 = B.Pop();
                    switch ((d[i])[0])
                    {
                        case '+':
                            B.Push(t2 + t1);
                            break;
                        case '-':
                            B.Push(t2 - t1);
                            break;
                        case '*':
                            B.Push(t2 * t1);
                            break;
                        case '/':
                            B.Push(t2 / t1);
                            break;
                    }
                }
            }
            B.View();
        }
    }
}
