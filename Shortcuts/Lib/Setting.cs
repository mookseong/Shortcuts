using System;
using System.Collections.Generic;
using System.IO;
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
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(Path);
            var nodeList = xmlDoc.SelectNodes("/Root/Data");

            if (nodeList == null) return;
            foreach (XmlNode xmlNode in nodeList)
            {
                Console.WriteLine(
                    xmlNode.Attributes?["Index"].Value + @"," +
                    xmlNode.SelectSingleNode("./Name")?.InnerText + @"," +
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