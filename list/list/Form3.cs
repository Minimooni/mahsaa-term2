using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form3 : Form
    {
        Form5 f5 = new Form5();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compelect");
            f5.Show();
        }
    }
}
