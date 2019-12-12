using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shortcuts.Lib;

namespace Shortcuts
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var fileInfo = new FileInfo(@"C:\mookseong\config.xml");
            if (!fileInfo.Exists)
            {
                var xml = new Xml();
                xml.XmlCreate();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
