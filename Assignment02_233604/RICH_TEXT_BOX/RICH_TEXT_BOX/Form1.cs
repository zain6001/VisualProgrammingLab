using System;
using System.Drawing;
using System.Windows.Forms;

namespace RICH_TEXT_BOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Arial", 12);
            richTextBox1.ForeColor = Color.Black;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightKeywords();
        }

        private void HighlightKeywords()
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            string[] keywords = { "important", "note", "urgent" };
            foreach (var keyword in keywords)
            {
                int startIndex = 0;
                while ((startIndex = richTextBox1.Find(keyword, startIndex, RichTextBoxFinds.None)) != -1)
                {
                    richTextBox1.SelectionStart = startIndex;
                    richTextBox1.SelectionLength = keyword.Length;
                    richTextBox1.SelectionColor = Color.Red;
                    startIndex += keyword.Length;
                }
            }

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e) // For Bold
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e) // For Italic
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e) // For Underline
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Style.HasFlag(style))
                {
                    newStyle = currentFont.Style & ~style;
                }
                else
                {
                    newStyle = currentFont.Style | style;
                }

                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
        }
    }
}
