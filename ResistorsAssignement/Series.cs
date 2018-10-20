﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistorsAssignement
{// this creates images objects for me to refer to
    public partial class Series : Form
    {
        private Image sd;
        private Image sr2;
        private Image sr3;
        private Image sr4;
        private Image sr5;
        // this assigns the image objects to the resources
        public Series()
        {
            InitializeComponent();

            sd = Properties.Resources.series;
            sr2 = Properties.Resources._2seriesresistors;
            sr3 = Properties.Resources._3seriesresistors;
            sr4 = Properties.Resources._4seriesresistors;
            sr5 = Properties.Resources._5seriesresistors;

        }
        // this makes the screen change to the other screen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // this calculates the numbers in the first 2 resistor boxes and changes the image in the picture box to the correct one
        private void button2_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == sd)
            {
                pictureBox1.Image = sr2;
            }
            else
            {
                pictureBox1.Image = sr2;
            }


            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double rt = r1 + r2;
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";

                
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
        // this calculates the numbers in the first 3 resistor boxes and changes the image in the picture box to the correct one
        private void button3_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == sd)
            {
                pictureBox1.Image = sr3;
            }
            else
            {
                pictureBox1.Image = sr3;
            }

            try
            {

                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double rt = r1 + r2 + r3;
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
            
        }
        // this calculates the numbers in the first 4 resistor boxes and changes the image in the picture box to the correct one
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == sd)
            {
                pictureBox1.Image = sr4;
            }
            else
            {
                pictureBox1.Image = sr4;
            }

            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double rt = r1 + r2 + r3 + r4;
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
        // this calculates the numbers in the first 5 resistor boxes and changes the image in the picture box to the correct one
        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == sd)
            {
                pictureBox1.Image = sr5;
            }
            else
            {
                pictureBox1.Image = sr5;
            }

            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double r5 = Convert.ToDouble(textBox5.Text);
                double rt = r1 + r2 + r3 + r4 + r5;
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
        // this makes the exit picture close the app when clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
