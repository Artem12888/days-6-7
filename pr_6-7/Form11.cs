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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mas = textBox1.Text.Split(' ');
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(mas[i]);
            }
            int min = num[0];
            int max = num[0];
            int minIn = 1;
            int maxIn = 1;
            for (int i = 1; i < 10; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                    minIn = i+1;
                }
                if (num[i] > max)
                {
                    max = num[i];
                    maxIn = i + 1;
                }
            }
            int fiExIn = Math.Min(minIn, maxIn);
            label3.Text = "Номер экстремального: " + fiExIn;
        }
    }
}
