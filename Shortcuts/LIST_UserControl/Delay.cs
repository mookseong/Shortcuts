using System;
using System.Windows.Forms;

namespace Shortcuts.LIST_UserControl
{
    public partial class Deleay : UserControl
    {
        public static string text { get; private set; }
        public Deleay()
        {
            InitializeComponent();
        }


        private void TEXT_TextChanged(object sender, EventArgs e) 
            => text = TEXT.Text;
        
    }
}