﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MidTerm287
{
    public partial class Form1 : Form        
    {
        Random numGen = new Random();
        int val = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close it?",
               "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else  
            {
                return;
            }
        }

        private void showNumbersButton_Click(object sender, EventArgs e)
        {
            generateNumbers();
        }

        private void generateNumbers()
        {
            val = numGen.Next(1, 60);
            num1.Text = val.ToString();

            val = numGen.Next(1, 60);
            while(val.ToString().Equals(num1.Text))
                val = numGen.Next(1, 60);
            num2.Text = val.ToString();

            val = numGen.Next(1, 60);
            while(val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text))
                val = numGen.Next(1, 60);
            num3.Text = val.ToString();

            val = numGen.Next(1, 60);
            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text))
                val = numGen.Next(1, 60);
            num4.Text = val.ToString();

            val = numGen.Next(1, 60);
            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text) || val.ToString().Equals(num4.Text))
                val = numGen.Next(1, 60);
            num5.Text = val.ToString();

            val = numGen.Next(1, 36);
            num6.Text = val.ToString();
        }         

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lottery by David Cruz" , "About");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}