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
    public partial class AddUc : UserControl
    {
        public AddUc()
        {
            InitializeComponent();
        }

        private void FormStart(Control control) => control.Show();
        
        private void button1_Click(object sender, EventArgs e) 
            => FormStart(new AddForm("Program"));
        
        private void button4_Click(object sender, EventArgs e)
            => FormStart(new AddForm("Delay"));
        
    }
}
