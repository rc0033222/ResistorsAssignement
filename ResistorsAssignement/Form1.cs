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
        // this makes the screen change to the other screen
        private void button1s_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Series();
            newForm.Show();
            
        }
        // this makes the screen change to the other screen
        private void button2p_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Parallel();
            newForm.Show();
           
        }
        // this makes the exit picture close the app when clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
