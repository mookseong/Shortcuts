using System;
using System.Windows.Forms;

namespace Shortcuts.LIST_UserControl
{
    public partial class ProgramStart : UserControl
    {
        public static string File { get; private set; }
        
        public ProgramStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = @"시작 프로그램 설정", 
                DefaultExt = "*", 
                Filter = @"모든 파일 (*.*) | *.*"
            };
            openFile.ShowDialog();
            foreach (var filename in openFile.FileNames)
                File = filename;
        }
    }
}