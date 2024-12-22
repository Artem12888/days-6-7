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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb = Convert.ToInt32(numericUpDown1.Value);
            int[] mas = new int[numb];
            Random ran = new Random();
            for (int i = 0; i < numb; i++)
            {

                mas[i] = ran.Next(0, 100);
                textBox1.Text = textBox1.Text + mas[i].ToString() + "\r\n";
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            int firstMin = -1;
            int lastMin = -1;
            int firstMax = -1;
            int lastMax = -1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    firstMin = i;
                    lastMin = i;
                }
                else if (mas[i] == min)
                {
                    lastMin = i;
                }
                if (mas[i] > max)
                {
                    max = mas[i];
                    firstMax = i;
                    lastMax = i;
                }
                else if (mas[i] == max)
                {
                    lastMax = i;
                }
            }
            firstMin = firstMin + 1;
            firstMax = firstMax + 1;
            lastMin = lastMin + 1;
            lastMax = lastMax + 1;
            label2.Text = "Минимальное значение " + min + " на позициях: " + firstMin + " (первое), " + lastMin + " (последнее)\n";
            label3.Text = "Максимальное значение " + max + " на позициях: " + firstMax + " (первое), " + lastMax + " (последнее)";
        }
    }
}
