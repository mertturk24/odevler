using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatrisCarpımı
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int[,] matris1 = new int[3, 3];
        int[,] matris2 = new int[3, 3];
        int[,] matris3 = new int[3, 3];
        Random salla = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView3.Rows.Add();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris1[i, j] = salla.Next(1, 10);
                    matris2[i, j] = salla.Next(1, 10);
                    dataGridView1.Rows[i].Cells[j].Value = matris1[i, j];
                    dataGridView2.Rows[i].Cells[j].Value = matris2[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matris3[i, j] += matris1[i, k] * matris2[k, j];
                        dataGridView3.Rows[i].Cells[j].Value = matris3[i, j];
                    }
                }
            }
        }
    }
}
        


        
    

