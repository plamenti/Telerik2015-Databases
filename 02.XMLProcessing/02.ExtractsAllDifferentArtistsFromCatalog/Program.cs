namespace _02.ExtractsAllDifferentArtistsFromCatalog
{
    using Loger;

    internal class Program
    {
        private const string PathToXml = "../../Catalog.xml";
        private const string ItemToExtract = "artist";

        private static void Main()
        {
            //2. Write program that extracts all different artists which are found in the catalog.xml.
            //For each author you should print the number of albums in the catalogue.
            //Use the DOM parser and a hash-table.

            DOMExtractor domExtractor = new DOMExtractor(PathToXml, ItemToExtract);
            ILoger consoleLoger = new ConsoleLoger();
            consoleLoger.Log(domExtractor.ExtractItems());
        }
    }
}