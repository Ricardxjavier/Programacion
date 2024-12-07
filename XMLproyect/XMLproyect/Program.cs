using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace WorkingWithXML
{ 

    class program
    { 
        static void main(string[] args)
        {
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resorce\WikimediaExample.xml");
        
        }


        private static void UsingXmlReader(string path)
        { 
            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read()) 
            {

                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "project")) 
                {
                    
                    if(xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("Name") + " : " + xmlReader.GetAttribute("launch"));


                }
            
                else if((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name ==  "edition"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("lenguaje"));

                }


            }

            Console.ReadKey();

        }
        

    }
   

}