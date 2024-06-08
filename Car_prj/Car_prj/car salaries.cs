using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_prj
{
    public partial class car_salaries : Form
    {
        public car_salaries()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double rate = 50000;
            textBox3.Text = rate.ToString();
            
        }

        private void D2(object sender, EventArgs e)
        {
            double D2 = int.Parse(textBox2.Text);


        }

        private void C2(object sender, EventArgs e)
        {
             double C2 = int.Parse(textBox3.Text);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int D2 = Convert.ToInt32(textBox2.Text);
                int C2 = Convert.ToInt32(textBox3.Text);
                int result = D2 * C2;
                MessageBox.Show("sum = " + result.ToString());
            }

            catch
            { 
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sum(object sender, EventArgs e)
        {

        }

        private void E2(object sender, EventArgs e)
        {
           
            
        }

        private void S2(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
            {
                

                

            try
            {
                int D2 = Convert.ToInt32(textBox2.Text);
                int C2 = Convert.ToInt32(textBox3.Text);
                int result = D2 * C2;

                int E2 = Convert.ToInt32(textBox5.Text);
                int S2 = Convert.ToInt32(textBox6.Text);
                int result2 = E2 * S2;
                int result3 = D2 * C2 + E2 * S2;
                MessageBox.Show("sum = " + result3.ToString());
            }

            catch
            {
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                try
                {
                    int E2 = Convert.ToInt32(textBox5.Text);
                    int S2 = Convert.ToInt32(textBox6.Text);
                    int result = E2 * S2;
                    MessageBox.Show("sum = " + result.ToString());
                }

                catch
                {
                }
            }

        }
    }

