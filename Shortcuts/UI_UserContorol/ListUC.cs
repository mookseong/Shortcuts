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
                           
                        break;
                    case "Delay":
                            
                        break;
                }
            }
        }
        
    }
}
