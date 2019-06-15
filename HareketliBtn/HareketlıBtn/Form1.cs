using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
        }
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Button.MousePosition.X;
            int y = Button.MousePosition.Y;
            label1.Text = Button.MousePosition.X.ToString() + "x" + Button.MousePosition.Y.ToString();

            this.button1.Location = new System.Drawing.Point(x - 25, y - 28);
            //label2.Text = ButtonBase.DefaultBackColor.R.ToString();

            /*int x = button1.Location.X;
            int y = button1.Location.Y;
            if (x>=this.ClientSize.Width)
            {
                button1.Location = new Point(0, button1.Location.Y);
                button1.Location = new Point(button1.Location.X - 75, button1.Location.Y);
            }
            else
            {
                button1.Location = new Point(x + 1, button1.Location.Y);
            }
            if (y >= this.ClientSize.Width)
            {
                button1.Location = new Point(button1.Location.X, 0);
                button1.Location = new Point(button1.Location.X, button1.Location.Y-23);
            }
            else
            {
                button1.Location = new Point(button1.Location.X, y + 1);
            }*/
        }
        }
}
