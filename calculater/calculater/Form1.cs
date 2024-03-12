namespace calculater
{
    public partial class Form1 : Form
    {

        double num1 = 0;
        double result;
        double num2 = 0;
        char op;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            try {
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num1 != 0)
                            result = num1 / num2;
                        else MessageBox.Show("wrong");
                        break;


                }
         }   catch  {
            
                textBox1.Text = "0";
            }
            textBox1.Text = result.ToString();

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
            num1 = double.Parse(textBox1.Text);
           
            op = Convert.ToChar(((Button)sender).Text);
            textBox1.Text = "0";




        }
    }
}