namespace _05.ExtractsAllSongTitlesWIthXMLReader
{
    using System;
    using System.Xml;

    internal class Program
    {
        private static string PathToXml = "../../Catalog.xml";

        private static void Main()
        {
            // 5. Write a program, which using XmlReader extracts all song titles from catalog.xml.

            Console.WriteLine("Song titles in the catalog:");
            using (XmlReader reader = XmlReader.Create(PathToXml))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}