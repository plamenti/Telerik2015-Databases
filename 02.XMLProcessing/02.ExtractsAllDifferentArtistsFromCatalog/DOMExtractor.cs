namespace _02.ExtractsAllDifferentArtistsFromCatalog
{
    using System.Collections.Generic;
    using System.Xml;

    public class DOMExtractor
    {
        private IDictionary<string, int> result;
        private XmlDocument doc;
        private string pathToXml;
        private XmlNode root;
        private string itemToExtract;

        public DOMExtractor(string pathToXml, string itemToExtract)
        {
            this.result = new Dictionary<string, int>();
            this.doc = new XmlDocument();
            this.pathToXml = pathToXml;
            this.root = this.GetRoot();
            this.itemToExtract = itemToExtract;
        }

        public IDictionary<string, int> ExtractItems()
        {
            foreach (XmlNode album in this.root.ChildNodes)
            {
                var artist = album[itemToExtract].InnerText;
                if (!this.result.ContainsKey(artist))
                {
                    this.result.Add(artist, 1);
                }
                else
                {
                    this.result[artist]++;
                }
            }

            return this.result;
        }

        private XmlNode GetRoot()
        {
            this.doc.Load(pathToXml);
            XmlNode root = doc.DocumentElement;

            return root;
        }
    }
}