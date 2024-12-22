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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mas= textBox1.Text.Split(' ');
            int[] numb = new int[10];
            for (int i =0; i<10; i++)
            {
                numb[i] = Convert.ToInt32(mas[i]);
            }
            int minEv = int.MinValue;
            int maxEv = int.MaxValue;
            int minOdd = int.MinValue;
            int maxOdd = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                if (numb[i] % 2 == 0)
                {
                    if (numb[i] < minEv)
                    {
                        minEv = numb[i];
                    }
                    if (numb[i] > maxEv)
                    {
                        maxEv = numb[i];
                    }
                }
                else
                {
                    if (numb[i] < minOdd)
                    {
                        minOdd = numb[i];
                    }
                    if (numb[i] > maxOdd)
                    {
                        maxOdd = numb[i];
                    }
                }
            }
            minEv = minEv == int.MinValue ? 0 : minEv;
            maxEv = maxEv == int.MaxValue ? 0 : maxEv;
            minOdd = minOdd == int.MinValue ? 0 : minOdd;
            maxOdd = maxOdd == int.MaxValue ? 0 : maxOdd;
            label3.Text = "Мин.Чёт: " + minEv + ", Макс.Чёт: " + maxEv + ", Мин.Нечёт: " + minOdd + ", Макс.Нечёт: " + maxOdd;
        }
    }
}
