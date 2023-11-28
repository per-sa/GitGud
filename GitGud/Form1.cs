using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System;
using System.Text;
using System.Windows.Forms;


namespace GitGud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ReceiveData(string data)
        {
            listBox1.Items.Add(data);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new ProcessStartInfo
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/settings/tokens",
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid token");
                return;
            }
            else
            {
                RunPythonScript();
            }

        }

        private void RunPythonScript()
        {
            try
            {
                string python = @"C:\Python312\python.exe";
                // path to script
                string myPythonScript = @"C:\Users\main.py";


                // Additional arguments to pass to your Python script, if any
                string args = string.Format("{0}", myPythonScript);

                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = args
                };

                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo = myProcessStartInfo;
                    myProcess.Start();

                    StreamReader myStreamReader = myProcess.StandardOutput;
                    StringBuilder output = new StringBuilder();

                    while (!myStreamReader.EndOfStream)
                    {
                        string line = myStreamReader.ReadLine();
                        output.AppendLine(line);
                    }

                    Console.WriteLine(output.ToString());

                    myProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDirs addDirs = new AddDirs(this);
            addDirs.Show();
        }
    }
}