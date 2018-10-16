using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistorsAssignement
{
    public partial class Series : Form
    {
        public Series()
        {
            InitializeComponent();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double rt = r1 + r2;
                label11.Text = "The Answer is " + rt;
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double rt = r1 + r2 + r3;
                label11.Text = "The Answer is " + rt;
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double rt = r1 + r2 + r3 + r4;
                label11.Text = "The Answer is " + rt;
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double r5 = Convert.ToDouble(textBox5.Text);
                double rt = r1 + r2 + r3 + r4 + r5;
                label11.Text = "The Answer is " + rt;
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
    }
}
