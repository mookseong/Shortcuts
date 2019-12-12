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
                    PanelUserControlAdd(new Volume());
                    break;
                case "Ip":
                    var ip = new TextControl();
                    panel1.Controls.Add(ip);
                    ip.Text1.Text = @"IP주소 불러와서 표시하기";
                    break;
                case "Today":
                    var today = new TextControl();
                    panel1.Controls.Add(today);
                    today.Text1.Text = @"IP주소 불러와서 표시하기";
                    break;
                case "Copy":
                    PanelUserControlAdd(new FileControl());
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
            
            list.Add(_type, data);
            
            if (path != null)
            {
                list.Add("Option", data);
                list.Add("Path", path);
            }
            var xml = new Xml();
            xml.XmlWrite(_type, list);
        }
        
        private void IndexAdd(string data ,string path, string path2)
        {
            var list = new Dictionary<string, string>();
            list.Add(data, data);
            list.Add("File", path);
            list.Add("Dir", path2);
         
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
                case "Date":
                    IndexAdd("Date", null);
                    break;
                case "Volume":
                    IndexAdd(Volume.Index, null);
                    break;
                case "Ip":
                    IndexAdd("Ip", null);
                    break;
                case "Today":
                    break;
                case "Copy":
                    IndexAdd("Copy", FileControl.FilePath, FileControl.FilePath);
                    break;
                default:
                    MessageBox.Show(@"뭔가 잘못된것 같아요 데이터를 저장하는 중에 오류가 발생했어요", @"뭐지?");
                    break;
            }
            Close();
        }
    }
}