namespace list
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f5.Show();
        }
    }
}