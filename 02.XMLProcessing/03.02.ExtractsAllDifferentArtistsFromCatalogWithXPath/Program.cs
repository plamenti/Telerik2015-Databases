namespace _03.ExtractsAllDifferentArtistsFromCatalogWithXPath
{
    using Loger;

    internal class Program
    {
        // 3. Write program that extracts all different artists which are found in the catalog.xml.
        // For each author you should print the number of albums in the catalogue.
        // Use the XPath parser and a hash-table

        private static string PathToXml = "../../Catalog.xml";
        private static string xPathQuery = "/albums//album";

        private static void Main(string[] args)
        {
            ILoger consoleLoger = new ConsoleLoger();

            XPathExtractor xPathExtractor = new XPathExtractor(PathToXml, "artist");
            consoleLoger.Log(xPathExtractor.ExtractItems(xPathQuery));
        }
    }
}