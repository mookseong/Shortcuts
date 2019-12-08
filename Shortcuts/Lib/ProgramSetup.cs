using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Shortcuts.Lib
{
    class ProgramSetup 
    {
        private readonly string _programPath;
        private readonly string[] _option;
        private string _program;
        
        public ProgramSetup(string programPath, string[] option)
        {
            _programPath = programPath;
            _option = option;
            OptionRegister();
        }

        private void OptionRegister() 
            => _program = _programPath + _option.Aggregate(" ", (current, t) => current + " " + t);

        public void Start()
        {
            try
            {
                Thread thread = new Thread(Open);
                thread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(@"에러발생 : " + e);
                MessageBox.Show(@"오류가 발생했습니다.", e.ToString());
                throw;
            }
            
        }
        private void Open() => Process.Start(_program);

    }
}