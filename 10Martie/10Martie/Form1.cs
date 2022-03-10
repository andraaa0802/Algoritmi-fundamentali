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

namespace _10Martie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool pciuc(int n)
        {
            int uc = n % 10;
            while (n >= 10)
                n /= 10;
            if (uc == n)
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"..\..\Resurse\TextFile1.txt");
            List<string> data = new List<string>();
            string buffer;
            while ((buffer = load.ReadLine()) != null)
                data.Add(buffer);

            for (int i = 0; i < data.Count; i++)
            {
                string[] temp = data[i].Split(new char[] { ' ', '_' });
                for (int j = 0; j < temp.Length; j++)
                {
                    int itmp = int.Parse(temp[j]);
                    if (pciuc(itmp))
                        listBox1.Items.Add(itmp.ToString());
                }
                    
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
