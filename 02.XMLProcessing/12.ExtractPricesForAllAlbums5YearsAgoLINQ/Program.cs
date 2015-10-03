namespace _12.ExtractPricesForAllAlbums5YearsAgoLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class Program
    {
        private const string PathToXml = "../../Catalog.xml";

        private static void Main(string[] args)
        {
            // 12. Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            // Use LINQ

            XDocument doc = XDocument.Load(PathToXml);

            var albumPrices =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select new
                {
                    Price = album.Element("price").Value,
                };

            foreach (var currentAlbumPrice in albumPrices)
            {
                Console.WriteLine("Price: {0}", currentAlbumPrice.Price);
            }
        }
    }
}