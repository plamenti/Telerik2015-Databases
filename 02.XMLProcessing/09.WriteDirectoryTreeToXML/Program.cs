using System;

namespace _09.WriteDirectoryTreeToXML
{
    using System.IO;
    using System.Text;
    using System.Xml;

    internal class Program
    {
        private const string DirectoryTreeXmlFile = "../../DirectoryTree.xml";

        private static void Main(string[] args)
        {
            // 09. Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            // Use tags <file> and <dir> with appropriate attributes. For the generation of the XML document use the class XmlWriter.

            string startDirectory = Environment.CurrentDirectory;
            var rootDirectory = new DirectoryInfo(startDirectory);
            using (XmlTextWriter writer = new XmlTextWriter(DirectoryTreeXmlFile, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 1;
                writer.IndentChar = '\t';

                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                TraverseDirectory(writer, rootDirectory);
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDirectory(XmlTextWriter writer, DirectoryInfo startDirectory)
        {
            foreach (var dir in startDirectory.GetDirectories())
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dir.Name);
                TraverseDirectory(writer, dir);
            }

            foreach (var file in startDirectory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}