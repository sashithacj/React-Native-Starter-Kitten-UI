using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            TopMost = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            metroTextBox2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
