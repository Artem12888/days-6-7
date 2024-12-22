using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_6_7
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input = textBox1.Text.Split(' ');
            int[] mas = new int[10];
            for (int i = 0; i< 10; i++)
            {
                mas[i] = Convert.ToInt32(input[i]); 
            }
            int minEl = mas[0];
            int maxEl = mas[0];
            int minIn = 1;
            int maxIn = 1;
            for (int i = 1; i < 10; i++)
            {
                if (mas[i] < minEl)
                {
                    minEl = mas[i];
                    minIn = i + 1;           
                }
                if (mas[i] > maxEl)
                {
                    maxEl = mas[i];
                    maxIn = i + 1;
                }
            }
            int firstIn = Math.Min(minIn, maxIn);
            label2.Text = "Ответ: " + firstIn;
        }
    }
}
