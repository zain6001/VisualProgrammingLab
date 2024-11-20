namespace lab7_Task6
{
    public partial class Form1 : Form
    {
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = (int)numericUpDown1.Value; 
            label2.Text = $"Time Left: {timeLeft} Seconds"; 
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; // Decrease the time left by 1 second
                label2.Text = $"Time Left: {timeLeft} Seconds"; // Update the label
            }
            else
            {
                timer1.Stop(); // Stop the timer
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show message box
            }
        }
    }
}
