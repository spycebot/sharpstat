using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace sharpstat
{
    public partial class SharpStatForm : Form
    {
        private string fileName = "";
        private string fileDialogFilter = "dat files (*.dat)|*.dat|csv files (*.csv)|*.csv|All files (*.*)|*.*";
        public SharpStatForm()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = fileDialogFilter;
            fileChooser.RestoreDirectory = true;

            DialogResult result = fileChooser.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = fileChooser.FileName;
                OpenFile(fileName);
            }
        }

        private void OpenFile(string fileName)
        {
            textBoxFilePathDisplay.Text = fileName;
            string[] path_parts = fileName.Split('.');
            Console.WriteLine($"Path parts length: {path_parts.Length}");
            Console.WriteLine($"Last element: {path_parts[path_parts.Length - 1]}");
            labelFileTypeReadout.Text = path_parts[path_parts.Length - 1];
        }

        private void SharpStatForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
