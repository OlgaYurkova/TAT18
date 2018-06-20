using System;
using System.IO;
using System.Collections;

namespace task_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            InformationElements rootElement = new InformationElements(null, "", "");

            if (args.Length == 1)
            {
                XmlParser xmlParser = new XmlParser(args[0], rootElement);
                xmlParser.Parse();
            }   
                 
            PrintXML printXML = new PrintXML(rootElement);
            printXML.Print();
        }
    }
}

