using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static lab6.Form1;

namespace lab6
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
        public class Student
        {
            public string Name { get; set; }
            public string FName { get; set; }
            public int Age { get; set; }

            public string Course { get; set; }

        }

        List<Student> std = new List<Student>();

    

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = std;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Student temp = new Student
            {
                Name = textBox1.Text,
                FName = textBox2.Text,
                Age = int.Parse(textBox3.Text),
                Course = textBox4.Text
            };
            std.Add(temp);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = std;
        }
    }
}
