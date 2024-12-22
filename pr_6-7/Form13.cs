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
    public partial class Form13 : Form
    {
        public Form13()
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
            int minStr = 0;
            int maxStr = 0;
            int minStrStr = 0;
            int maxStrStr = 0;
            for (int i = 0; i < 10; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (num[i] == min)
                {
                    minStrStr++;
                    if (minStrStr > minStr)
                    {
                        minStr = minStrStr;
                    }
                }
                else
                {
                    minStrStr = 0;
                }
                if (num[i] == max)
                {
                    maxStrStr++;
                        if (maxStrStr > maxStr)
                    {
                        maxStr = maxStrStr;
                    }
                }
                else
                {
                    maxStrStr = 0;
                }
            }
            label3.Text = "Макс подряд мин " + minStrStr + "Макс подряд макс " + maxStrStr;
        }
    }
}
