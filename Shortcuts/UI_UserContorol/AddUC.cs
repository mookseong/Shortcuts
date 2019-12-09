using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shortcuts.Lib;

namespace Shortcuts.UI_UserContorol
{
    public partial class AddUC : UserControl
    {
        public AddUC()
        {
            InitializeComponent();
        }

        private void Add()
        {
            var list = new Dictionary<string, string>();
            list.Add("tses111","test");
            list.Add("tses1","test");
           
            var xml = new XML();
            xml.XmlWrite("tset", 2, list);
//           
//           xml.XmlRead();
        }
    }
}
