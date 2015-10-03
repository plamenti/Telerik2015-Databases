using System.Xml.Xsl;

namespace _13._14.CreateXSLStylesheet
{
    internal class Program
    {
        private const string PathToXml = "../../Catalog.xml";
        private const string PathToHtml = "../../Catalog.html";
        private const string PathToXslt = "../../Catalog.xslt";

        private static void Main()
        {
            // 13. Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, formatted for viewing in a standard Web-browser.
            // 14. Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class XslTransform.

            var xslt = new XslCompiledTransform();
            xslt.Load(PathToXslt);
            xslt.Transform(PathToXml, PathToHtml);
        }
    }
}