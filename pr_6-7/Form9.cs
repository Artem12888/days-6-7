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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input = textBox1.Text.Split(' ');
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = Convert.ToInt32(input[i]);
            }
            int minEl = mas[0];
            int maxEl = mas[0];
            int minInd = 0;
            int maxInd = 0;
            for (int i = 1; i < 10; i++)
            {
                if (mas[i] < minEl)
                {
                    minEl = mas[i];
                    minInd = i;
                }
                if (mas[i] > maxEl)
                {
                    maxEl = mas[i];
                    maxInd = i;
                }
            }
            int beforeMin = minInd;
            int afterMax = 10 - maxInd - 1;
            textBox2.Text = "Количество элементов перед минимальным = " + beforeMin + " " + "Количество элементов после максимального = " + afterMax;
        }
    }
}
