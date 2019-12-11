using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shortcuts.Lib;
using Shortcuts.LIST_UserControl;

namespace Shortcuts
{
    public partial class AddForm : Form
    {
        private readonly string _type;
        public AddForm(string type)
        {
            _type = type;
            InitializeComponent();
            switch (type)
            {
                case "Program":
                    PanelUserControlAdd(new ProgramStart());
                    break;
                case "Shutdown":
                    PanelUserControlAdd(new Shutdown());
                    break;
                case "Delay":
                    PanelUserControlAdd(new Deleay());
                    break;
                case "Volume":
                    break;
                case "Ip":
                    break;
                case "Today":
                    break;
            }
        }
        
        private void PanelUserControlAdd(Control model)
        {
            panel1.Controls.Add(model);
            model.Show();
            model.BringToFront();
        }

        private void IndexAdd(string data ,string path)
        {
            var list = new Dictionary<string, string>();
            if (_type == "Shutdown" || _type == "Delay")
                list.Add("Time", data);
            if (path != null)
            {
                list.Add("Option", data);
                list.Add("Path", path);
            }
            var xml = new Xml();
            xml.XmlWrite(_type, list);
        }

        private void 저장_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case "Program":
                    if (_type == "Program" && ProgramStart.File != null)
                        IndexAdd("Option", ProgramStart.File);
                    else
                    {
                        MessageBox.Show(@"시작프로그램이 선택되어 있지 않습니다", @"뭔가 잘못된것같아요");
                        return;
                    }
                    break;
                case "Shutdown":
                    IndexAdd(Shutdown.Text, null);
                    break;
                case "Delay":
                    IndexAdd(Deleay.text, null);
                    break;
                default:
                    MessageBox.Show(@"뭔가 잘못된것 같아요\n작동범위를 벗어났습니다.", @"뭐지?");
                    break;
            }
            Close();
        }
    }
}