namespace _04.DeleteAlbumsHavingPriceBiggerThen20
{
    using System.Collections.Generic;
    using System.Xml;

    public class DOMRemover
    {
        private const string Artist = "artist";
        private IDictionary<string, int> result;
        private XmlDocument doc;
        private string pathToXml;
        private XmlNode root;
        private string itemToRemove;

        public DOMRemover(string pathToXml, string itemToRemove)
        {
            this.result = new Dictionary<string, int>();
            this.doc = new XmlDocument();
            this.itemToRemove = itemToRemove;
            this.pathToXml = pathToXml;
            this.root = this.GetRoot();
        }

        public void RemoveAlbumByPrice(double price)
        {
            List<XmlNode> itemsToRemove = new List<XmlNode>();
            foreach (XmlNode album in this.root.ChildNodes)
            {
                double priceOfAlbum = double.Parse(album[itemToRemove].InnerText);

                if (priceOfAlbum > price)
                {
                    itemsToRemove.Add(album);
                }
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                this.root.RemoveChild(itemToRemove);
            }
        }

        public IDictionary<string, int> ExtractItemsByArtist()
        {
            if (this.result.Keys.Count != 0)
            {
                this.result = new Dictionary<string, int>();
            }
            foreach (XmlNode album in this.root.ChildNodes)
            {
                var artist = album[Artist].InnerText;
                var price = album[this.itemToRemove].InnerText;
                if (!this.result.ContainsKey(artist))
                {
                    this.result.Add(artist + ", album price: " + price, 1);
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