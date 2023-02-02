using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindows
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GreetMe(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            MessageBox.Show(txtname.Text + " You have clicked " + c.Text);
        }
    }
}
