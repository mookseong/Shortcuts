using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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

    class XML
    {
        private const string Path = @"C:\mookseong\config.xml";

        public void XmlCreate()
        {
            Directory.CreateDirectory(@"C:\mookseong\");
            var newXmlDoc = new XmlDocument();
            newXmlDoc.AppendChild(newXmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));
            newXmlDoc.AppendChild(newXmlDoc.CreateElement("", "Root", ""));
            newXmlDoc.Save(Path);
        }

        private int xmlSize()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);
            var count = xmlDoc.SelectNodes("/Root/Data")?.Count;
            if (count != null) return (int) count;
            return -1;
        }
        
        public void XmlRead()
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(Path);
            var nodeList = xmlDoc.SelectNodes("/Root/Data");

            if (nodeList == null) return;
            foreach (XmlNode xmlNode in nodeList)
            {
                Console.WriteLine(
                    xmlNode.Attributes?["Index"].Value + "," +
                    xmlNode.SelectSingleNode("./Name")?.InnerText + "," +
                    xmlNode.SelectSingleNode("Dept")?.InnerText);

                foreach (XmlNode child in xmlNode.ChildNodes)
                {
                    Console.WriteLine(@"{0}: {1}", child.Name, child.InnerText);
                }
            }
        }
        
        private XmlNode CreateNode(XmlDocument xmlDoc, string name, string innerXml)
        {
            XmlNode node = xmlDoc.CreateElement(string.Empty, name, string.Empty);
            node.InnerXml = innerXml;

            return node;
        }
        
        public void XmlWrite(string type, Dictionary<string, string> dictionary)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);
            
            var root = xmlDoc.CreateElement("Data");
            root.SetAttribute("Index", xmlSize() == -1 ? "1" : xmlSize().ToString());
            root.SetAttribute("Type", type);

            foreach (var i in dictionary)
                root.AppendChild(CreateNode(xmlDoc, i.Key, i.Value));
            
            xmlDoc.DocumentElement?.AppendChild(root);
            xmlDoc.Save(Path);
        }
    }
}