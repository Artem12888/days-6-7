using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_6_7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string[] mas = textBox1.Text.Split(' ');
            int[] numb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numb[i] = Convert.ToInt32(mas[i]);
            }
            int min = numb[0];
            int max = numb[0];
            int minCo = 0;
            int maxCo = 0;
            for (int i = 0; i < 10; i++)
            {
                if (numb[i] < min)
                {
                    min = numb[i];
                }
                if (numb[i] > max)
                {
                    max = numb[i];
                }
            }
            for (int i = 0; i< 10; i++)
            {
                if (numb[i] == min)
                {
                    minCo++;
                }
                if (numb[i] == max)
                {
                    maxCo++;
                }
            }
            label3.Text = "Кол-во мин: " + minCo + ", кол-во макс: " + maxCo;
        }
    }
}
