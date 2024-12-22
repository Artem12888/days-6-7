using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pr_6_7
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ab = textBox1.Text.Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);
            string[] input = textBox2.Text.Split(' ');
            int[] mas = new int[10];
            for (int i =0; i < 0; i++)
            {
                mas[i] = Convert.ToInt32(input[i]);
            }
            int minRa = int.MinValue;
            int maxRa = int.MaxValue;
            bool found = false;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i] > a && mas[i] < b)
                {
                    if (mas[i] < minRa)
                    {
                        minRa = mas[i];
                    }
                    if (mas[i] > maxRa) 
                    {
                        maxRa = mas[i];
                    }
                    found = true;
                }
            }
            if (!found)
            {
                label3.Text = "Мин: -1, Макс: -1";
            }
            else
            {
                label3.Text = "Мин: " + minRa + ", Макс: " + maxRa;
            }
        }
    }
}
