namespace lab7_task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Timer properties
            timer1.Interval = 1000; // Update every 1 second
            timer1.Start(); // Start the timer

            // Initialize the date and time display
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            // Update the date
            label1.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            // Update the time
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the date and time every second
            UpdateDateTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
