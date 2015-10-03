namespace _11.ExtractPricesForAllAlbums5YearsAgo
{
    using System;
    using System.Xml;

    internal class Program
    {
        private const string PathToXml = "../../Catalog.xml";

        private static void Main()
        {
            // 11. Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            // Use XPath query.

            XmlDocument doc = new XmlDocument();
            doc.Load(PathToXml);
            XmlNode rootNode = doc.DocumentElement;
            string xPathYearQuery = "/albums/album[year<2010]/price";
            XmlNodeList albumPrices = rootNode.SelectNodes(xPathYearQuery);

            foreach (XmlNode currentAlbumPrice in albumPrices)
            {
                Console.WriteLine("Price: {0}", currentAlbumPrice.InnerText);
            }
        }
    }
}