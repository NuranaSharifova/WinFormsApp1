using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void Resume_Click(object sender, EventArgs e)
        {
           int count = 0;
           string resume= "My name is Nurana Sharifova";
           DialogResult result=  MessageBox.Show(resume,"Resume",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            count = resume.Length;
            MessageBox.Show($"Number of symbols {count}");

            if (result == DialogResult.Yes)
            {
                resume = "I am a student IT STEP Academy";
                result=MessageBox.Show(resume, "Resume", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                count += resume.Length;
                MessageBox.Show($"Number of symbols {count}");
                if (result == DialogResult.Yes)
                {
                    resume = "I work at Azertexnolayn MMC ";
                    MessageBox.Show(resume, "Resume", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    count += resume.Length;
                    MessageBox.Show($"Number of symbols {count}");
                }
             
            }
            
        }
    }
}
