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
    public partial class Form7 : Form
    {
        public Form7()
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
            int minPos = int.MaxValue;
            int maxNeg = int.MinValue;
            for (int i = 0; i < 10; i++)
            {
                if (numb[i] > 0 && numb[i] < minPos)
                {
                    minPos = numb[i];
                }
                if (numb[i] < 0 && numb[i] > maxNeg)
                {
                    maxNeg = numb[i];
                }
                minPos = minPos == int.MinValue ? 0 : minPos;
                maxNeg = maxNeg == int.MaxValue ? 0 : maxNeg;
                label3.Text = "Мин.положит.: " + minPos + ", Макс. отриц.: " + maxNeg;
            }
        }
    }
}
