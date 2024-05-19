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
    public partial class Form2 : Form
    {
        Form4 f4 = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string lastname;
            lastname = textBox1.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi" + " please inter the list" );
                
            f4.Show();
        }
    }
}
