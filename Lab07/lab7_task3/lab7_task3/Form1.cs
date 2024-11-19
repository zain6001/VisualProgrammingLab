namespace lab7_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateSquare(int number)
        {
            return number * number;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous rows in the ListView
            listView1.Items.Clear();

            // Set ListView to display in Details view
            listView1.View = View.Details;

            // Loop through numbers 1 to 10 and calculate squares
            int square;
            for (int i = 1; i <= 10; i++)
            {
                 square = CalculateSquare(i);

                // Create a new row with Number and Square
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(square.ToString());

                // Add the row to the ListView
                listView1.Items.Add(item);
            }
        }
    }
}
