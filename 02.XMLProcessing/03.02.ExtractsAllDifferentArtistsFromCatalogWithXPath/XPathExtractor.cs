namespace _03.ExtractsAllDifferentArtistsFromCatalogWithXPath
{
    using System.Collections.Generic;
    using System.Xml;

    internal class XPathExtractor
    {
        private IDictionary<string, int> result;
        private XmlDocument doc;
        private string pathToXml;
        private string itemToExtract;

        public XPathExtractor(string pathToXml, string itemToExtract)
        {
            this.result = new Dictionary<string, int>();
            this.doc = new XmlDocument();
            this.pathToXml = pathToXml;
            this.itemToExtract = itemToExtract;
        }

        public IDictionary<string, int> ExtractItems(string xPathQuery)
        {
            this.doc.Load(pathToXml);
            //string xPathQuery = "/albums//album";
            XmlNodeList albums = doc.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
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
    }
}