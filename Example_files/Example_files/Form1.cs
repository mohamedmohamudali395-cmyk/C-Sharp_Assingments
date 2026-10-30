using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Example_files
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter writing_file;

            writing_file = File.CreateText("index.txt");

            writing_file.Close();

            MessageBox.Show("File Created Successfully");
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter writing_file;

            writing_file = File.CreateText("index.txt");

            writing_file.WriteLine("Welcome to C# Programming");
            writing_file.WriteLine("Chapter 4: Files");
            writing_file.WriteLine("StreamWriter Class");

            writing_file.Close();

            MessageBox.Show("File Written Successfully");
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            StreamWriter writing_file;

            writing_file = File.AppendText("index.txt");

            writing_file.WriteLine("This is New Information");

            writing_file.Close();

            MessageBox.Show("Data Appended Successfully");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader reading_file;

            reading_file = File.OpenText("index.txt");

            string lines;

            lines = reading_file.ReadLine();

            listBox1.Items.Add(lines);

            reading_file.Close();
        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            StreamReader reading_file;

            reading_file = File.OpenText("index.txt");

            string lines;

            lines = reading_file.ReadToEnd();

            listBox1.Items.Add(lines);

            reading_file.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("index.txt"))
            {
                File.Delete("index.txt");

                listBox1.Items.Clear();

                MessageBox.Show("File Deleted Successfully");
            }
            else
            {
                MessageBox.Show("File Does Not Exist");
            }
        }


    }
    }


