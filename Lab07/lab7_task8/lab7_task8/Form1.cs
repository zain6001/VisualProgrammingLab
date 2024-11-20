namespace lab7_task8
{
    public partial class Form1 : Form
    {
        private string[] imageFiles; // Array to store all image file paths
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open a Folder Browser Dialog
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    textBox1.Text = selectedPath;

                    // Get all image files from the selected folder
                    imageFiles = Directory.GetFiles(selectedPath, "*.*")
                                          .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                         file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                         file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                         file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                         file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                          .ToArray();

                    // Update total photos label
                    label2.Text = $"Total Photos: {imageFiles.Length}";

                    if (imageFiles.Length > 0)
                    {
                        currentIndex = 0; // Reset to the first image
                        DisplayImage();   // Display the first image
                    }
                    else
                    {
                        MessageBox.Show("No images found in the selected folder.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pictureBox1.Image = null;
                    }
                }
            }
        }
        private void DisplayImage()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]); // Load and display the image
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1) % imageFiles.Length; // Move to next image
                DisplayImage();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Length; // Move to next image
                DisplayImage();
            }
        }
    }
}

