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
    public partial class Form12 : Form
    {
        public Form12()
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
            int maxMin = int.MinValue;
            int maxMax = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                if (num[i] > maxMin)
                {
                    maxMax = maxMin;
                    maxMin = num[i];
                }
                else if (num[i] > maxMax && num[i] < maxMin)
                {
                    maxMax = num[i];
                }
                label3.Text = "Наибольшие: " + maxMax + ", " + maxMin;
            }
        }
    }
}
