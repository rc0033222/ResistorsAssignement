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
    public partial class Parallel : Form
    {
        public Parallel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double rt = 1 / (1 / r1 + 1 / r2);
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
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3);
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
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3) + (1.0 / r4);

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
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3) + (1.0 / r4) + (1.0 / r5);

                label11.Text = "The Answer is " + rt;
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
    }
}
