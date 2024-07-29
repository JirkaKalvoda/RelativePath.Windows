using System;
using System.Windows.Forms;
using RelativePath.Windows;

namespace RelativePathTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool success = RelativePathComputer.GetRelativePath(tb_input.Text, tb_reference.Text, tb_tolerance.Text, out string output);
            l_output.Text = success.ToString();
            tb_output.Text = output;
        }
    }
}
