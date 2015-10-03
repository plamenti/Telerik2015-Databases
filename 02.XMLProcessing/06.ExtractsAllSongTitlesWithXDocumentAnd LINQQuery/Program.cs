namespace _06.ExtractsAllSongTitlesWithXDocumentAnd_LINQQuery
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class Program
    {
        private static string PathToXml = "../../Catalog.xml";

        private static void Main(string[] args)
        {
            // 5. Write a program, which using XDocument and LINQ query extracts all song titles from catalog.xml.

            Console.WriteLine("Song titles in the catalog:");
            XDocument xmlDoc = XDocument.Load(PathToXml);
            var albums = xmlDoc.Element("albums").Elements("album");

            foreach (var album in albums)
            {
                var songs = album.Descendants("songs");
                var titles =
                    from title in songs.Descendants("title")
                    select title.Value;

                foreach (var title in titles)
                {
                    Console.WriteLine(title);
                }
            }
        }
    }
}