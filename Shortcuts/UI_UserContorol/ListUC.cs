using System;
using System.Windows.Forms;
using System.Xml;
using Shortcuts.Lib;
using Shortcuts.LIST_UserControl;

namespace Shortcuts.UI_UserContorol
{
    public partial class ListUC : UserControl
    {
        public ListUC()
        {
            InitializeComponent();
            Set();
        }
        
        public void Set()
        {
            flowLayoutPanel1.Controls.Clear();
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(@"C:\mookseong\config.xml");
            var nodeList = xmlDoc.SelectNodes("/Root/Data");
            if (nodeList == null) return ;
            foreach (XmlNode xmlNode in nodeList)
            {
                switch (xmlNode.Attributes?["Type"].Value)
                {
                    case "Program":
                        var programStart = new ProgramStart();
                        flowLayoutPanel1.Controls.Add(programStart);
                        programStart.button1.Enabled = false;
                        break;
                    case "Shutdown":
                        var shutdown = new Shutdown();
                        flowLayoutPanel1.Controls.Add(shutdown);
                        shutdown.textBox1.Enabled = false;
                        break;
                    case "Delay":
                        var deleay = new Deleay();
                        flowLayoutPanel1.Controls.Add(deleay);
                        deleay.TEXT.Text = xmlNode.InnerText;
                        deleay.TEXT.Enabled = false;
                        break;
                    case "Volume":
                        var volume = new Volume();
                        flowLayoutPanel1.Controls.Add(volume);
                        volume.textBox1.Text = xmlNode.InnerText;
                        volume.textBox1.Enabled = false;
                        break;
                    case "Ip":
                        var ip = new TextControl();
                        flowLayoutPanel1.Controls.Add(ip);
                        ip.Text1.Text = @"IP주소 불러와서 표시하기";
                        break;
                    case "Date":
                        var date = new TextControl();
                        flowLayoutPanel1.Controls.Add(date);
                        date.Text1.Text = @"날자와 시간 표시";
                        break;
                    case "Today":
                        var today = new TextControl();
                        flowLayoutPanel1.Controls.Add(today);
                        today.Text1.Text = @"IP주소 불러와서 표시하기";
                        break;
                    case "Copy":
                        var fileControl = new FileControl();
                        flowLayoutPanel1.Controls.Add(fileControl);
                        fileControl.button1.Enabled = false;
                        fileControl.button2.Enabled = false;
                        break;
                }
            }
        }

        
    }
}
