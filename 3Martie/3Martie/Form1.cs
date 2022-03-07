using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Martie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c, d, e_;
        private void Form1_Load(object sender, EventArgs e)
        {
            a = rnd.Next(10);
            b = rnd.Next(10);
            c = rnd.Next(10);
            d = rnd.Next(10);
            e_ = rnd.Next(10);

            textBox1.Text = a + " " + b + " " + c + " " + d + " " + e_;

            int aux;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (a > d)
            {
                aux = a;
                a = d;
                d = aux;
            }
            if (a > e_)
            {
                aux = a;
                a = e_;
                e_ = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (b > d)
            {
                aux = b;
                b = d;
                d = aux;
            }
            if (b > e_)
            {
                aux = b;
                b = e_;
                e_ = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (c > e_)
            {
                aux = c;
                c = e_;
                e_ = aux;
            }
            if (d > e_)
            {
                aux = d;
                d = e_;
                e_ = aux;
            }

            textBox3.Text = a + " " + b + " " + c + " " + d + " " + e_;
            if ((a == b) && (a == c) && (a == d) && (a == e_))
                textBox2.Text = "5 val id.";
            else
            {
                if (((a == b) && (a == c) && (a == d)) && ((b == c) && (b == d) && (b == e_)))
                    textBox2.Text = "4 val id.";
                else
                {
                    if (((a == b) && (a == c) && (d == e_))&&((a == b) && (c == d) && (c == e_)))
                        textBox2.Text = "3 val id. + 2 val id.";
                    else
                    {
                        if (((a == b) && (a == c))&&((b == c) && (b == d))&&((c == d) && (c == e_)))
                            textBox2.Text = "3 val id.";
                        else
                        {
                            
                            if (((a == b) && (c == d))&&((a == b) && (d == e_))&&((b == c) && (d == e_)))
                                textBox2.Text = "2 val id. + 2 val id.";
                            else
                            {
                                if ((a == b)&&(b == c)&&(c == d)&&(d == e_))
                                    textBox2.Text = "2 val id.";
                                else
                                    textBox2.Text = "nimic";
                            }
                        }
                    }
                }
            }
        }
    }
}
