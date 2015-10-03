namespace _07.CreatesXMLDocumentWithDataFromTextFile
{
    using System.IO;
    using System.Xml.Linq;

    internal class Program
    {
        //  7. In a text file we are given the name, address and phone number of given person (each at a single line).
        // Write a program, which creates new XML document, which contains these data in structured XML format.
        private static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
            }

            XElement persons =
                new XElement("persons",
                    new XElement("person",
                        new XElement("name", person.Name),
                        new XElement("address", person.Address),
                        new XElement("phoneNumber", person.PhoneNumber)
                    )
                );

            persons.Save("../../persons.xml");
        }
    }
}