using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Shortcuts.Lib
{
    public class WindowsFunction
    {
        
        //컴퓨터 볼륨 조절을 위한 .dll참조
        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        //컴퓨터 종료
        private void Shutdown(int time) 
            => Process.Start("shshutdown", "/s /t " + time);

        //딜레이 
        private DateTime Delay(int i)
        {
            var thisMoment = DateTime.Now;
            var duration = new TimeSpan(0, 0, 0, 0, i);
            
            while (thisMoment.Add(duration) >= thisMoment)
                thisMoment = DateTime.Now;
            
            return DateTime.Now;
        }
        
        //날자 불러오기
        private string Date() 
            => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
        //컴퓨터 볼륨 조절
        private void SetSoundVolume(ushort volume)
        {
            try
            {
                var value = (int)((double)volume * ushort.MaxValue / 100);
                waveOutSetVolume(IntPtr.Zero, (uint)value & 0x0000ffff | (uint)value << 16);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"에러코드" + e, @"오류가 발생했습니다.");
                throw;
            }
        }
        
        //파일 복사하기
        private void Copy(string fileName, string source, string target)
        {
            var destFile = Path.Combine(target, fileName);
            Directory.CreateDirectory(target);
            
            File.Copy(Path.Combine(source, fileName), destFile, true);
            
            if (Directory.Exists(source))
            {
                foreach (var s in Directory.GetFiles(source))
                {
                    fileName = Path.GetFileName(s);
                    destFile = Path.Combine(target, fileName);
                    File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine(@"위치를 찾을 수 없습니다.");
            }
        }

        private void FileMove(string source, string  destination, bool dir)
        {
            if (dir)
                Directory.Move(source, destination);
            else
                File.Move(source, destination);
        }

        private void Delete(string source, bool dir)
        {
            if (dir)
            {
                if (File.Exists(source))
                {
                    try
                    {
                        File.Delete(source);
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                        MessageBox.Show( @"에러 코드 : " + e.Message, @"에러가 발생했습니다");
                    }
                }
                else
                    MessageBox.Show(@"사용자의 경로를 확인 할 수 없습니다.",@"에러가 발생했습니다");
            }
            else
            {
                if (Directory.Exists(source))
                {
                    try
                    {
                        Directory.Delete(source, true);
                    }

                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                        MessageBox.Show(@"에러 코드 : " + e.Message, @"에러가 발생했습니다");
                    }
                }else
                    MessageBox.Show( @"사용자의 경로를 확인 할 수 없습니다.",@"에러가 발생했습니다");
            }
        }
        
        public string Ip()
        {
            var localIp = "";
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily != AddressFamily.InterNetwork) continue;
                localIp = ip.ToString();
                break;
            }
            return localIp;
        }
    }
    
    public class ControlStatement
    {
        public bool IfFunction(int a, int b, string Operator)
        {
            switch (Operator)
            {
                case "==":
                    return a == b;
                case "<":
                    return a < b;
                case ">":
                    return a > b;
                case "!=":
                    return a != b;
                default:
                    MessageBox.Show(@"연산자에 문제가 발생했습니다.", @"Error");
                    break;
            }
            return false;
        }

        public void WhileFunction(int a, int b, string Operator )
        {
            while (IfFunction(a, b, Operator))
            {
                
            }
        }
    }
    
    internal class ProgramSetup 
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