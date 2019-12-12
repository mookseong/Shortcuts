using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Shortcuts.LIST_UserControl;

namespace Shortcuts.Lib
{
     internal class Xml
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
        
        public void XmlDelete()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path); //xml파일 읽고
            
            var root = xmlDoc.DocumentElement;
            root?.RemoveChild(root.ChildNodes[1]);
            
            xmlDoc.Save(Path);
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


     class Start
     {
         public void ProgramStart()
         {
             var xmlDoc = new XmlDocument();

             xmlDoc.Load(@"C:\mookseong\config.xml");
             var nodeList = xmlDoc.SelectNodes("/Root/Data");
             MessageBox.Show(xmlDoc.SelectNodes("/Root/Data")?.Count.ToString());
            
             if (nodeList == null) return ;
             foreach (XmlNode xmlNode in nodeList)
             {
                 var windowsFunction = new WindowsFunction();
                 foreach (XmlNode child in xmlNode.ChildNodes)
                 {
                     switch (child.Name)
                     {
                         case "Path":
                             var programSetup = new ProgramSetup(child.InnerText, null);
                             programSetup.Open();
                             break;
                         case "Date":
                             windowsFunction.Date();
                             break;
                         case "Shutdown":
                             windowsFunction.Shutdown(int.Parse(child.InnerText));
                             break;
                         case "Delay":
                             windowsFunction.Delay(int.Parse(child.InnerText));
                             break;
                         case "Volume":
                             windowsFunction.SetSoundVolume(ushort.Parse(child.InnerText));
                             break;
                         case "Ip":
                             windowsFunction.Ip();
                             break;
                         case "Today":
                             break;
                         case "Copy":
                             windowsFunction.Copy("","","");
                             break;
                     }
                 }
             }
         }
     }
}