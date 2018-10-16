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
            this.Hide();
            var newForm = new Series();
            newForm.Show();
        }

        private void button2p_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Parallel();
            newForm.Show();
        }
    }
}
