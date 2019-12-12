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

        private void button5_Click(object sender, EventArgs e)
        {
            FormStart(new AddForm("Volume"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStart(new AddForm("Shutdown"));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormStart(new AddForm("Ip"));
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            FormStart(new AddForm("Copy"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormStart(new AddForm("Date"));
        }
    }
}
