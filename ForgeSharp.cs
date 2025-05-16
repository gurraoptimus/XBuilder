using System;
using System.Xml.Linq;

namespace XML_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("RootName",
                    new XElement("Child1", "data1"),
                    new XElement("Child2",
                        new XAttribute("Name", "CodeJunk"), "myvalue")
                )
            );

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                          @"\source\repos\Xbuilder\index.xml";
            xDoc.Save(path);
        }
    }
}
