using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shortcuts.Lib;
using Shortcuts.UI_UserContorol;

namespace Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homeUC.BringToFront();

            if (Directory.Exists( @"C:\mookseong\") != false) return;
            var xml = new XML();
            xml.XmlCreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           homeUC.BringToFront();
           var list = new Dictionary<string, string>();
           list.Add("tses111","test");
           list.Add("tses1","test");
           
           var xml = new XML();
           xml.XmlWrite("tset", 2, list);
//           
//           xml.XmlRead();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addUC.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listUC.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
