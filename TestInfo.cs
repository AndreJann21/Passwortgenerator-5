using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwortgenerator5_WF
{
    public partial class TestInfo : Form
    {
        string Test;
        public TestInfo(string Test1)
        {
            Test = Test1;
            InitializeComponent();
        }

        private void TestInfo_Load(object sender, EventArgs e)
        {
            label1.Text = Test;
        }
    }
}
