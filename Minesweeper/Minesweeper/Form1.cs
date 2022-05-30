using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class iButton:Button
    {
        public int lin, col;
    }
    public partial class Form1 : Form
    {
        iButton[,] T;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 20, m = 14;
            T = new iButton[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    T[i, j] = new iButton();
                    T[i, j].Size = new Size(20, 20);
                    T[i,j].Parent = this;
                    T[i, j].Location = new Point(60 + i * 21, 60 + j * 21);
                    T[i, j].Click += Form1_Click;
                    T[i, j].lin = i;
                    T[i, j].col = j;
                }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int l = (sender as iButton).lin;
            int c=(sender as iButton).col;
            MessageBox.Show(l + " " + c);
        }
    }
}
