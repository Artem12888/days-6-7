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
    public partial class Form3 : Form
    {
        public Form3()
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
            int min = mas[0];
            for (int i = 0; i < mas.Count(); i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
            }
            int max = mas[0];
            for (int i = 0; i < mas.Count(); i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }
            int minIn = 0;
            int maxIn = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < mas[minIn])
                {
                    minIn = i;
                }
            }
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > mas[maxIn])
                {
                    maxIn = i;
                }
            }
            minIn = minIn + 1;
            maxIn = maxIn + 1;
            label2.Text = "Минимальный: " + min + " на позиции " + minIn;
            label3.Text = "Максимальный: " + max + " на позиции " + maxIn;
        }
    }
}
