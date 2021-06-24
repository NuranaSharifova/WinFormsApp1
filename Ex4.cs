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
        Point point;
       
        public Ex4()
        {

            InitializeComponent();
            point = new Point();
        }

      

        private void Ex4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                point.X = e.Location.X;
                point.Y = e.Location.Y;

            }
           
        }

        private void Ex4_MouseUp(object sender, MouseEventArgs e)
        {

            Button button = new Button();


            if (e.Location.X > point.X && e.Location.Y > point.Y)
            {
                button.Location = new System.Drawing.Point(point.X, point.Y);


            }
            else if (e.X > point.X && e.Y < point.Y)
            {
                button.Location = new Point(point.X, e.Y);
            }
            else if (e.X < point.X && e.Y < point.Y)
            {
                button.Location = new Point(e.X, e.Y);
            }
            else
            {
                button.Location = new Point(e.X, point.Y);
            }
            if (Math.Abs(e.X - point.X) <= 10 || Math.Abs(e.Y - point.Y) <= 10)
            {
                MessageBox.Show("Impossible to create static little than 10х10", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            button.Name = "Hello";
            button.Text = "rectangal";
            button.Size = new System.Drawing.Size(e.Location.X, e.Location.Y);
            button.Location = new System.Drawing.Point(0, 126);
            button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 51);
            button.UseVisualStyleBackColor = true;
            this.Controls.Add(button);
            
            button.MouseClick += ButtonMouseClick;
            //button.MouseClick += DoubleMouseClick;

        }
        }
        private void ButtonMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Button item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $" Area {item.Width * item.Height}, Coordinates Х = {item.Location.X} Y = {item.Location.Y}";
                    }
                }
            }
        }
        private void DoubleMouseClick(object sender, MouseEventArgs e)
        {


            foreach (Button item in Controls)
            {

                Controls.Remove(item);

            }
        }

    }

}

