using System;
using System.Windows.Forms;

namespace Shortcuts.LIST_UserControl
{
    public partial class FileControl : UserControl
    {
        public static string FilePath;
        public static string DirPath;
        public FileControl()
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
                FilePath = filename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openDir = new FolderBrowserDialog();
            openDir.ShowDialog();
            DirPath = openDir.SelectedPath;
        }
    }
}