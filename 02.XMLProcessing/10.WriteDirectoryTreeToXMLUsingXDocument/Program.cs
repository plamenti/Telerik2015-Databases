namespace _10.WriteDirectoryTreeToXMLUsingXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class Program
    {
        private const string DirectoryTreeXmlFile = "../../DirectoryTree.xml";

        private static void Main()
        {
            // 10. Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            // Use tags <file> and <dir> with appropriate attributes. For the generation of the XML document use XDocument, XElement and XAttribute.

            string startDirectory = Environment.CurrentDirectory;
            var rootDirectory = new DirectoryInfo(startDirectory);

            XElement directoryInfo = new XElement("root");
            directoryInfo.Add(TraverseDirectory(rootDirectory));

            directoryInfo.Save(DirectoryTreeXmlFile);
        }

        private static XElement TraverseDirectory(DirectoryInfo directory)
        {
            var el = new XElement("dir", new XAttribute("path", directory.Name));
            foreach (var dir in directory.GetDirectories())
            {
                el.Add(TraverseDirectory(dir));
            }

            foreach (var file in directory.GetFiles())
            {
                el.Add(new XElement("file", new XAttribute("name", file.Name)));
            }

            return el;
        }
    }
}