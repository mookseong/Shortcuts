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
            if (option == null)
            {
                ProgramPathRegister();
                return;
            }
            _option = option;
            OptionRegister();

        }

        private void ProgramPathRegister() => _program = _programPath;
        private void OptionRegister() 
            => _program = _programPath + _option.Aggregate(" ", (current, t) => current + " " + t);

        public void Start()
        {
            try
            {
                var thread = new Thread(Open);
                thread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show( e.ToString(),@"오류가 발생했습니다.");
                throw;
            }
            
        }

        public void Open() => Process.Start(_program);

    }
}