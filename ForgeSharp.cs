using System;
using System.Xml.Linq;

namespace XML_Studio
{ class Program 
    { static void Main(string[] args)
        {Document xDoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("RootName",
                new XElement("Child1","data1"),
                new XElement("Child2",
                    new XAttribute("Name", "CodeJunk"), "myvalue")
                )
            );

            
        }
    }
}