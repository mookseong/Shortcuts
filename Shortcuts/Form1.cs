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
            homeUC.BringToFront();

            var fileInfo = new FileInfo(@"C:\mookseong\config.xml");
            if (fileInfo.Exists) return;
            var xml = new Xml();
            xml.XmlCreate();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(@"C:\mookseong\config.xml");
            var nodeList = xmlDoc.SelectNodes("/Root/Data");
            MessageBox.Show(xmlDoc.SelectNodes("/Root/Data")?.Count.ToString());
            
            if (nodeList == null) return ;
            foreach (XmlNode xmlNode in nodeList)
            {
                
                foreach (XmlNode child in xmlNode.ChildNodes)
                {
                    switch (child.Name)
                    {
                            
                        case "Path":
                            var programSetup = new ProgramSetup(child.InnerText, null);
                            programSetup.Open();
                            break;
                        case "Time":
                            break;
//                        default:
//                            MessageBox.Show(@"오류가 발생한거같아요", @"뭥미");
//                            break;
                    }
                }
            }

        }
    }
}
