using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Car_prj
{
    public partial class Drivers : Form
    {
        string id_1;
        public Drivers()
        {
            InitializeComponent();
        }
        car_salaries Cs = new car_salaries();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string fami = textBox2.Text;
                string code = textBox3.Text;
                string nump = textBox4.Text;
                string tele = textBox5.Text;
                string addr = textBox6.Text;
                string query = "INSERT INTO Drivers(name,Family,ncode,numberplate,mobile,address)" + "VALUES('" + name + "','" + fami + "','" + code + "','" + nump + "','" + tele + "','" + addr + "')";

                SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\pro\Car_prj\Car_prj\Database1.mdf;Integrated Security=True");
                Sc.Open();
                SqlCommand sqlCommand = new SqlCommand(query, Sc);
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inser Succesful");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
                    refresh();
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }

                Sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errrrrorrr" + ex.Message);
            }
        }
        void refresh()
        {
            comboBox1.Items.Clear();
            string query = "SELECT * FROM Drivers";

            SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\pro\Car_prj\Car_prj\Database1.mdf;Integrated Security=True");
            Sc.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Sc);

            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["id"] + ":" + dr["Name"] + " " + dr["Family"]);
            }
            Sc.Close();
        }
        private void Drivers_Load(object sender, EventArgs e)
        {

            refresh();
            button4.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedItem.ToString();
            id = id.Substring(0, id.IndexOf(":"));
            try
            {

                string query = "DELETE FROM Drivers WHERE id='" + id + "'";


                SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\pro\Car_prj\Car_prj\Database1.mdf;Integrated Security=True");
                Sc.Open();
                SqlCommand sqlCommand = new SqlCommand(query, Sc);
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Delete Succesful");
                    refresh();

                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }

                Sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errrrrorrr" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button1.Enabled = false;
            string id = comboBox1.SelectedItem.ToString();
            id = id.Substring(0, id.IndexOf(":"));
            id_1 = id;
            comboBox1.Items.Clear();
            string query = "SELECT * FROM Drivers WHERE id = '" + id + "'";

            SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\pro\Car_prj\Car_prj\Database1.mdf;Integrated Security=True");
            Sc.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Sc);

            SqlDataReader dr = sqlCommand.ExecuteReader();
            dr.Read();
            textBox1.Text = dr["Name"].ToString();
            textBox2.Text = dr["Family"].ToString();
            textBox3.Text = dr["Ncode"].ToString();
            textBox4.Text = dr["Numberplate"].ToString();
            textBox5.Text = dr["Mobile"].ToString();
            textBox6.Text = dr["Address"].ToString();
            Sc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string fami = textBox2.Text;
                string code = textBox3.Text;
                string nump = textBox4.Text;
                string tele = textBox5.Text;
                string addr = textBox6.Text;
                string query = "UPDATE  Drivers SET name= '" + name + "',Family= '" + fami + "',ncode='" + code + "',numberplate='" + nump + "',mobile='" + tele + "',address='" + addr + "' WHERE id = '" + id_1 + "'";


                SqlConnection Sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\pro\Car_prj\Car_prj\Database1.mdf;Integrated Security=True");
                Sc.Open();
                SqlCommand sqlCommand = new SqlCommand(query, Sc);
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update Succesful");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
                    refresh();
                    button4.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

                Sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errrrror" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cs.Show();
        }
    }
}
    
      

