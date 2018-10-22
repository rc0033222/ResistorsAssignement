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

        private Image pd;
        private Image pr2;
        private Image pr3;
        private Image pr4;
        private Image pr5;
        // this assigns the image objects to the resources

        public Parallel()
        {
            InitializeComponent();

            pd = Properties.Resources.parallel;
            pr2 = Properties.Resources._2parallelresistors;
            pr3 = Properties.Resources._3parallelresistors;
            pr4 = Properties.Resources._4parallelresistors;
            pr5 = Properties.Resources._5parallelresistors;
               
        }
        // this makes the screen change to the other screen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();

        }
        // this adds the numbers in the first 2 resistor boxes and changes the image in the picture box to the correct one
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pd)
            {
                pictureBox1.Image = pr2;
            }
            else
            {
                pictureBox1.Image = pr2;
            }

            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double rt = 1 / (1 / r1 + 1 / r2);
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }

        }
        // this adds the numbers in the first 3 resistor boxes and changes the image in the picture box to the correct one
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pd)
            {
                pictureBox1.Image = pr3;
            }
            else
            {
                pictureBox1.Image = pr3;
            }

            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3);
                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
        // this adds the numbers in the first 4 resistor boxes and changes the image in the picture box to the correct one
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pd)
            {
                pictureBox1.Image = pr4;
            }
            else
            {
                pictureBox1.Image = pr4;
            }

            try



            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3) + (1.0 / r4);

                label11.Text = "The Answer is " + rt.ToString("0.00") + "Ω";
            }
            catch
            {
                MessageBox.Show("Enter a number please");
            }
        }
        // this adds the numbers in the first 5 resistor boxes and changes the image in the picture box to the correct one
        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == pd)
            {
                pictureBox1.Image = pr5;
            }
            else
            {
                pictureBox1.Image = pr5;
            }

            try
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double r5 = Convert.ToDouble(textBox5.Text);
                double rt = (1.0 / r1) + (1.0 / r2) + (1.0 / r3) + (1.0 / r4) + (1.0 / r5);

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
