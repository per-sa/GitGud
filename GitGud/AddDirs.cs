using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitGud
{
    public partial class AddDirs : Form
    {

        private Form1 MainForm;

        public AddDirs(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Optionally set any properties here
                // For example, you can set the Description property to provide a message to the user.
                folderBrowserDialog.Description = "Select a directory";

                // Show the dialog and get result
                DialogResult result = folderBrowserDialog.ShowDialog();

                // If the result is OK, get the selected path and set it to the TextBox
                if (result == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    textBox1.Text = selectedPath; // Set the selected path to the TextBox
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendDataDir();
        }

        private void SendDataDir()
        {
            MainForm.ReceiveData(textBox1.Text);
        }
    }
}
