namespace lab7_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Fahrenheit value from the TextBox
                double fahrenheit = double.Parse(textBox1.Text);

                // Convert Fahrenheit to Celsius
                double celsius = (fahrenheit - 32) * 5 / 9;

                // Display the Celsius value
                textBox2.Text = celsius.ToString("F2"); // Format to 2 decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Fahrenheit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
