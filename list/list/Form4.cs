using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace list
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] User = File.ReadAllLines("user.csv");
            for (int i = 0; i < User.Length; i++) ;
            {
                string[] a = User[i].Split(new char[] { ',' });
                listBox1.Items.Add(a[0] + "" + a[1]);
            }
               
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string fname = textBox2.Text;
            string phnum = textBox3.Text;
            string sum = name + ',' + fname + ',' + phnum + '\n';
            var fs = File.Create("information.csv");
            fs.Close();
            File.WriteAllText("information.csv", sum);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string fname = textBox2.Text;
            string phnum = textBox3.Text;
            string sum = name + ',' + fname + ',' + phnum + '\n';
            File.AppendAllText("information.csv" , sum);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

       
}
