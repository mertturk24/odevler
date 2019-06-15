using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HareketlıBtn2
{
    public partial class Form1 : Form
    {
        int islem = 0;
        int islem1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
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
                int x = button1.Location.X;
                int y = button1.Location.Y;
                int xboyut = this.ClientSize.Width;
                int yboyut = this.ClientSize.Height;

                if (islem == 0)
                {
                    if (x >= xboyut-75)
                    {
                        islem = 1;
                    }
                    else
                    {
                        button1.Location = new Point(x + 1, button1.Location.Y);
                    }

                }
                else if (islem == 1)
                {
                    if (x == 0)
                    {
                        islem = 0;
                    }
                    else
                    {
                        button1.Location = new Point(x - 1, button1.Location.Y);
                    }
                }
                if (islem1 == 0)
                {
                    if (y >= yboyut-23)
                    {
                        islem1 = 1;
                    }
                    else
                    {
                        button1.Location = new Point(button1.Location.X, y + 1);
                    }

                }
                else if (islem1 == 1)
                {
                    if (y == 0)
                    {
                        islem1 = 0;
                    }
                    else
                    {
                        button1.Location = new Point(button1.Location.X, y - 1);
                    }
                }
            }
        
    }
}

    

