using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblFork_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/trungdq88/FormulasTextBox");
        }
    }
}
