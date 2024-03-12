namespace calculater
{
    public partial class Form1 : Form
    {

        double num1 = 0;

        double num2 = 0;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
           char op = Convert.ToChar(((Button)sender).Text);

            num1 = Convert.ToDouble(textBox1.Text); Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox1.Text);
            double result;
            switch (op)
            {

                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result= num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;

            }
            textBox1.Text = num1.ToString();

        }

        private void numbtnclick(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = ((Button)sender).Text;
            else
            textBox1.Text+= ((Button)sender).Text;


        }
             

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void opbtnclick(object sender, EventArgs e)

        {
            double num1 = 0;
            char op;
           num1 = Convert.ToDouble(textBox1.Text); Convert.ToDouble(textBox1.Text);
            op = Convert.ToChar(((Button)sender).Text);
            textBox1.Text = "0";




        }
    }
}