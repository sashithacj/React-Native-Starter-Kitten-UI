using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace React_Native_Starter_Kitten_UI
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TopMost = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            metroTextBox2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            string ar;
            ar = "/c npm un -g react-native-cli && npm i -g @react-native-community/cli";
            cmd.StartInfo.Arguments = ar;
            //cmd.StartInfo.WorkingDirectory = metroTextBox2.Text;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.WaitForExit();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            string ar;
            ar = "/c npx react-native init " + metroTextBox1.Text + " --template @ui-kitten/template-js";
            cmd.StartInfo.Arguments = ar;
            cmd.StartInfo.WorkingDirectory = metroTextBox2.Text;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.WaitForExit();
        }
    }
}
