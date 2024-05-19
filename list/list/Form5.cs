using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace list
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            
            string sum = name + '\n';
            var fs = File.Create("product.csv");
            fs.Close();
            File.WriteAllText("product.csv", sum);
            textBox1.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            string sum = name + '\n';
            var fs = File.Create("product.csv");
            fs.Close();
            File.AppendAllText("product.csv", sum);
            textBox1.Text = "";

        }
    }
}
