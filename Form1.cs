using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Ex1 ex1 = new Ex1();
        Ex2 ex2 = new Ex2();
        Ex3 ex3 = new Ex3();
        Ex4 ex4 = new Ex4();
        Ex5 ex5 = new Ex5();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ex2.ShowDialog();
            ex2.progressBar1.Value = 0;
            ex2.textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ex1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ex3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ex4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ex5.ShowDialog();
        }
    }
}
