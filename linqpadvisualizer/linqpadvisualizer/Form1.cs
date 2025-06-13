using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQPadVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Set the title of the form to the name of the application
            InitializeComponent();
        }

        public void setHTML(string html)
        {
            webBrowser1.DocumentText = html;
        }
    }
}
