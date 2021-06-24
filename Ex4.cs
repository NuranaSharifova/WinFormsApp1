using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex4 : Form
    {
       
        public Ex4()
        {
            InitializeComponent();
           
        }

        private void Ex4_MouseMove(object sender, MouseEventArgs e)
        {

           
                Button button = new Button();
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                button.Name = "Hello";
                button.Text = "rectangal";
                button.Size = new System.Drawing.Size(103, 41);
                button.Location = new System.Drawing.Point(0, 126);
                button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 51);
                button.UseVisualStyleBackColor = true;
                this.Controls.Add(button);

         }
    }
}
