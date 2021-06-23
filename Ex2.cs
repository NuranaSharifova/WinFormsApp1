using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
           
         
        }

      

        private void Start_Click(object sender, EventArgs e)
        {
            int count = 0;
            int usernum = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            int compnum = rnd.Next(0, 2000);
            DialogResult dialogresult = new DialogResult();
            while (usernum != compnum)
            {
                count++;
                dialogresult = MessageBox.Show($"Computer guessed that number is {compnum}.It is false, So try again", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                compnum = rnd.Next(0, 2000);
                Thread.Sleep(50);
                if (dialogresult == DialogResult.Cancel)
                {

                    break;

                }
                progressBar1.Value++;
                progressBar1.Maximum++;

            }
            if (dialogresult != DialogResult.Cancel) MessageBox.Show($"Congratulations!Computer guessed that number is {compnum},Number of tries {count}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
