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
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

            
        }
        
        private void button1s_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void button2p_Click(object sender, EventArgs e)
        {
            
           
        }
        // this makes the exit picture close the app when clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
        // this sets the form background colour
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        //this sets the form background colour
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }
        // this changes the form to the selected one
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Parallel();
            newForm.Show();
        }
        // this changes the form to the selected one
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Series();
            newForm.Show();
        }
    }
}
