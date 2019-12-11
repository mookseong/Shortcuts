using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

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
        
        public void XmlRead()
        {
            
            return;
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