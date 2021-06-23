using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex3 : Form
    {
        int height = 40;
        int width = 100;
        public Ex3()
        {
            InitializeComponent();
          
        }




        private void Ex3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"Mouse Position: {e.Location}";

        }

        private void Ex3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                if (e.Location.X < width && e.Location.Y < height)
                {


                    MessageBox.Show("Mouse button is inside of rectangular");
                }
                else {
                    MessageBox.Show("Mouse button is outside of rectangular");

                }
            }
            else if (e.Button==MouseButtons.Right) {

                MessageBox.Show($"Form height is {this.Height}, Form Width {this.Width}");
            }
            
        }

        private void Ex3_Paint(object sender, PaintEventArgs e)
        {
         e.Graphics.DrawRectangle(new Pen(Brushes.Blue),new Rectangle(0,0,width,height));
        }
    }
}
