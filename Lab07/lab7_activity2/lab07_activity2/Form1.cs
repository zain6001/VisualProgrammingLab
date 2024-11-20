namespace lab07_activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = -1;
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Large");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get selected pizza size
            string pizzaSize = comboBox1.SelectedItem?.ToString() ?? "Not selected";

            // Get selected toppings
            string toppings = "";
            if (radioButton1.Checked) toppings += "Cheese, ";
            if (radioButton2.Checked) toppings += "Pepperoni, ";
            if (radioButton3.Checked) toppings += "Mushrooms, ";
            if (string.IsNullOrEmpty(toppings))
                toppings = "No toppings"; // Default message if no toppings are selected.
            else
                toppings = toppings.TrimEnd(',', ' '); // Remove trailing comma and space.

            // Get selected crust type
            string crustType = "";
            if (radioButton5.Checked)
                crustType = "Thin Crust";
            else if (radioButton6.Checked)
                crustType = "Thick Crust";
            else
                crustType = "Not selected";

            // Display the order summary
            label2.Text = $"Order Summary:\nSize: {pizzaSize}\nToppings: {toppings}\nCrust: {crustType}";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
