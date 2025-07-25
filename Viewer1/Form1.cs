using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text += $" ({Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")})";
        }

        private void _wtest_Click(object sender, EventArgs e)
        {
            _web.Navigate(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "wtest", "tests.html"));
        }

        private void _wtest2_Click(object sender, EventArgs e)
        {
            _web.Navigate(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "wtest2", "TEST_IFrame.htm"));
        }
    }
}
