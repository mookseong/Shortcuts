using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shortcuts.Lib;
using Shortcuts.LIST_UserControl;

namespace Shortcuts
{
    public partial class AddForm : Form
    {
        private ProgramStart test;
        private Control _control;
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
            _control = model;
            model.Show();
            model.BringToFront();
        }

        public void start()
        {
            var list = new Dictionary<string, string>();
            list.Add("Path","test1");
            list.Add("Data","test2");
           
            var xml = new Xml();
            xml.XmlWrite(_type, list);
        }

        private void 저장_Click(object sender, EventArgs e)
        {
          //test Line
            MessageBox.Show(ProgramStart.File, "");
            var programSetup = new ProgramSetup(ProgramStart.File, null);
            programSetup.Open();
        }
        
     
    }
}