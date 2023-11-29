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

        private async void button1_Click(object sender, EventArgs e)
        {
            await RunGitActionAsync("pull");
        }

        private async Task RunGitActionAsync(string command)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c " + "git " + command);

                foreach (var item in listBox1.Items)
                {
                    startInfo.WorkingDirectory = item.ToString();
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.RedirectStandardOutput = true;
                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        string output = await process.StandardOutput.ReadToEndAsync();
                        string error = await process.StandardError.ReadToEndAsync();

                        string formattedOutput = item.ToString() + "\n" + (error != "" ? error : output) + "\n";

                        this.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText(formattedOutput);
                        }));

                        await process.WaitForExitAsync();
                    }

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

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}