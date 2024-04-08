using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindFormProject
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hello, World","This is a title!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "This is a title!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Ok!");
            }
            else
            {
                MessageBox.Show("Why?");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "This is a title!", MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Ok!");
            }
            else
            {
                MessageBox.Show("Why?");
            }
        }
    }
}
