using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace sharpstat
{
    public partial class SharpStatForm : Form
    {
        private string fileName;
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
        }

        private void SharpStatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
