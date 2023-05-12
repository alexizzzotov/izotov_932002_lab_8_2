using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAnswer_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double p1 = 0.1;
            double p2 = p1 + 0.2;
            double p3 = p2 + 0.15;
            double p4 = p3 + 0.25;
            double p5 = p4 + 0.2;
            double p6 = p5 + 0.1;

            double a = rand.NextDouble();

            if (a < p1)
            {
                txtAns.Text = "Нет";
            }
            else if (a < p2)
            {
                txtAns.Text = "Сомневаюсь";
            }
            else if (a < p3)
            {
                txtAns.Text = "Не знаю";
            }
            else if (a < p4)
            {
                txtAns.Text = "Возможно";
            }
            else if (a < p5)
            {
                txtAns.Text = "Да";
            }
            else if (a < p6)
            {
                txtAns.Text = "Определенно";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
