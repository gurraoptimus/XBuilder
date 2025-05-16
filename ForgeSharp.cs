using System;
using System.IO;
using System.Xml.Linq;

namespace XML_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the XML document
            XDocument xDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("RootName",
                    new XAttribute("Name", "MyRootName"),
                    new XElement("Child1", "data1"),
                    new XElement("Child2",
                        new XAttribute("Name", "CodeJunk"), "myvalue")
                )
            );

            // Set the file path
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "source", "repos", "CreateXMLDocument", "index.xml"
            );

            // Ensure directory exists
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Save the XML document
            xDoc.Save(path);

            Console.WriteLine(@"XML file successfully saved to:\n{path}");
        }
    }
}
