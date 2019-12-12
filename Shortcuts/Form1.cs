using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Shortcuts.Lib;
using Shortcuts.LIST_UserControl;
using Shortcuts.UI_UserContorol;

namespace Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listUC.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           homeUC.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addUC.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listUC.BringToFront();
            listUC.Set();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var start = new Start();
            var t1 = new Thread(start.ProgramStart);
            t1.Start();
        }
    }
}
