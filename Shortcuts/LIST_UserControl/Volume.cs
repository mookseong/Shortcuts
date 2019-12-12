using System;
using System.Windows.Forms;

namespace Shortcuts.LIST_UserControl
{
    public partial class Volume : UserControl
    {
        public static string Index;
        public Volume()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 100 || int.Parse(textBox1.Text) >= 0)
            {
                Index = textBox1.Text;
            }
            else
                MessageBox.Show(@"0~100값을 넣어주세요", "Error");

        }
    }
}