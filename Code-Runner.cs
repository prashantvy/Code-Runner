using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Runner
{
    public partial class Code_Runner : Form
    {
        public string fileName;
        public bool chkdBox = false;
        public string filePath;

        public Code_Runner()
        {
            InitializeComponent();
            txtError.Font = new Font("Arial", 8);
            txtFile.Font = new Font("Arial", 12);
            txtInput.Font = new Font("Arial", 8);
            txtOutput.Font = new Font("Arial", 8);
            txtFile.Enabled = false;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkFile_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkFile.Checked)
                {
                    txtFile.Enabled = false;
                    chkdBox = true;
                    var directory = new DirectoryInfo(filePath);
                    var myFile = directory.GetFiles()
                     .OrderByDescending(f => f.LastWriteTime)
                     .First();

                    string name = myFile.Name;
                    txtFile.Text = name.Substring(0, name.Length - 4);
                }
                else
                {
                    txtFile.Enabled = true;
                    txtFile.Text = "";
                }
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }
        private void btnSetPath_Click(object sender, EventArgs e)
        {
            filePath = txtFilePath.Text;
            //For file path validation
            if (string.IsNullOrEmpty(filePath))
            {
                txtError.Text = "Please enter file path";
            }
            else if (!Path.IsPathRooted(filePath))
            {
                txtError.Text = "Invalid file path";
            }
            else
            {
                txtFile.Enabled = true;
                txtError.Text = "";
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            txtError.Text = "";
            string filePath = txtFilePath.Text;
            string fileName = txtFile.Text;

            //To check if file exists in given path
            if (!File.Exists($"{filePath}\\{fileName}.cpp"))
            {
                txtError.Text = "File not found at specified location. Please check your file name or path";
                fileName = "";
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = @"/c cd " + filePath + " ; if ($?) { g++ " + fileName + ".cpp -o " + fileName + " } ; if ($?) { .\\" + fileName + " }",
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            Process process = new Process
            {
                StartInfo = psi
            };

            try
            {
                process.Start();
                process.StandardInput.WriteLine(txtInput.Text);
                process.StandardInput.Close();
                process.WaitForExit();
                string result = process.StandardOutput.ReadToEnd();

                txtError.Text = process.StandardError.ReadToEnd();
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                txtError.Text = "An error occurred: " + ex.Message;
            }
            finally
            {
                process.Dispose();
            }
        }

        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
