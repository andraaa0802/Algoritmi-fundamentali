using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _10Martie_pb2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i<=n; i += 2)
                if ((n % i) == 0)
                    return false;
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            TextWriter save = new StreamWriter(@"..\..\data.txt");
            string t = "";
            for(int i=0;i<100;i++)
            {
                int x = rnd.Next(-100, 101);
                t += x + " ";
            }
            save.Write(t);
            save.Close();
            */

            TextReader load = new StreamReader(@"..\..\data.txt");
            string[] T = load.ReadLine().Split(' ');

            int nrc = 0;
            int max = 0;
            int poz = -1;
            for (int i = 0; i < T.Length; i++)
            {
                int tmp = int.Parse(T[i]);
                if (isPrime(tmp))
                    nrc++;
                else
                {
                    if (nrc > max)
                    {
                        max = nrc;
                        poz = i;
                    }
                    nrc = 0;
                }
            }
            if (poz == -1)
                listBox1.Items.Add("NU EXISTA");
            else
            {
                string buffer = "";
                for (int i = poz+max-1; i >= poz; i--)
                    buffer += T[i] + " ";
                listBox1.Items.Add(buffer);
            }
            
        }
    }
}
