using System;
using System.Windows.Forms;

namespace Shortcuts.LIST_UserControl
{
    public partial class Shutdown : UserControl
    {
        public static string Text;
        public Shutdown()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }
    }
}