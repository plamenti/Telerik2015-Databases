namespace _16.GenerateAnXSDSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    internal class Program
    {
        private const string PathToInvalidXml = "../../InvalidCatalog.xml";
        private const string PathToXml = "../../Catalog.xml";
        private const string PathToXsd = "../../Catalog.xsd";

        private static void Main()
        {
            // 16. Using Visual Studio generate an XSD schema for the file catalog.xml.
            // Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against the schema.
            // Test it with valid XML catalogs and invalid XML catalogs.

            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, PathToXsd);
            XDocument correctDoc = XDocument.Load(PathToXml);
            XDocument invalidDoc = XDocument.Load(PathToInvalidXml);

            Console.WriteLine("Validating valid xml:");
            ValidateXML(schema, correctDoc);
            Console.WriteLine();
            Console.WriteLine("Validating invalid xml:");
            ValidateXML(schema, invalidDoc);
        }

        private static void ValidateXML(XmlSchemaSet schema, XDocument xmlToValidate)
        {
            bool error = false;

            xmlToValidate.Validate(schema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                error = true;
            });

            Console.WriteLine("XML document {0}", error ? "is not valid" : "valid");
        }
    }
}