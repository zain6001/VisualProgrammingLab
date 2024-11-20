namespace lab7_task9
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the label with the total character count
            label1.Text = $"Characters Left: {MaxCharacters}";
            label1.Refresh();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Calculate the remaining characters
            int charsLeft = MaxCharacters - textBox1.Text.Length;

            // Prevent users from typing more than the allowed characters
            if (charsLeft < 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, MaxCharacters);
                textBox1.SelectionStart = textBox1.Text.Length; // Move cursor to the end
                charsLeft = 0;
            }

            // Update the label to display the number of characters left
            label1.Text = $"Characters Left: {charsLeft}";
        }
    }
}
