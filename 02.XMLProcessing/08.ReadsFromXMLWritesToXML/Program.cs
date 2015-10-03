namespace _08.ReadsFromXMLWritesToXML
{
    using System.Text;
    using System.Xml;

    internal class Program
    {
        private const string FileToRead = "../../Catalog.xml";
        private const string FileToWrite = "../../Album.xml";

        private static void Main(string[] args)
        {
            // 8. Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml,
            // in which stores in appropriate way the names of all albums and their authors

            Encoding encoding = Encoding.UTF8;

            using (XmlTextWriter writer = new XmlTextWriter(FileToWrite, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlTextReader reader = new XmlTextReader(FileToRead))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementString());
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            writer.WriteElementString("artist", reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteEndDocument();
            }
        }
    }
}