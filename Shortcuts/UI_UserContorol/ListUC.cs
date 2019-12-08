using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shortcuts.LIST_UserControl;

namespace Shortcuts.UI_UserContorol
{
    public partial class ListUC : UserControl
    {
        public ListUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1();
            
            flowLayoutPanel1.Controls.Add(test1);
        }
    }
}
