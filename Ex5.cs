using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void Ex5_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >button1.Location.X - 20 && e.X < button1.Location.X + button1.Width + 20) && (e.Y > button1.Location.Y - 20 && e.Y < button1.Location.Y + button1.Height + 20))
            {
                if (e.X > button1.Location.X - 20 && e.X < button1.Location.X)
                {
                    button1.Left += 10;
                }
                else if (e.X < button1.Location.X + button1.Width + 20 && e.X > button1.Location.X + button1.Width)
                {
                    button1.Left -= 10;
                }
                else if (e.Y > button1.Location.Y - 20 && e.Y < button1.Location.Y)
                {
                    button1.Top += 10;
                }
                else if (e.Y < button1.Location.Y + button1.Height + 20 && e.Y > button1.Location.Y + button1.Height)
                {
                    button1.Top -= 10;
                }

                if ((button1.Location.X < 0 || button1.Location.X > ClientSize.Width - button1.Width) || (button1.Location.Y < 0 || button1.Location.Y > ClientSize.Height - button1.Height))
                {
                    ButtonCenter(button1);
                }
                void ButtonCenter(Button button) 
                {
                    button1.Left = (ClientSize.Width - button1.Size.Width) / 2;
                    button1.Top = (ClientSize.Height - button1.Size.Height) / 2;
                }
            }
        }
    }
}
