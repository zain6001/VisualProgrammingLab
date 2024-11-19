namespace lab7_Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer.", "Error");
                    return;
                }
                textBox2.Text = CalculateFactorial(number).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

