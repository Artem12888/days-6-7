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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb = Convert.ToInt32(numericUpDown1.Value);
            int[] mas = new int[numb];
            Random rand = new Random();
            for (int i =0; i<numb; i++)
            {
                mas[i] = rand.Next(0, 100);
                textBox1.Text = textBox1.Text + mas[i].ToString() + "\r\n";
            }
            int min = mas[0];
            int max = mas[0];
            for (int i  = 0; i < mas.Count(); i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
            }
            for (int i =0; i<mas.Count(); i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }
            label2.Text = "Минимум " + min;
            label3.Text = "Максимум " + max;
        }
    }
}
