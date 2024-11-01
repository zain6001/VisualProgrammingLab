using System;
using System.Windows.Forms;

namespace DatetimePicker_MonthCalendar_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "DATE AND TIME YOU PICK: " + dateTimePicker1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "DATE AND PICK BY YOU: " + monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OpenImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                }
            }
        }
    }
}
