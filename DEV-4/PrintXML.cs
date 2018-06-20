using System;

namespace task_4
{
    /// <summary>
    /// This class prints XML file
    /// </summary>
    class PrintXML
    {
        public InformationElements rootElements;
        public PrintXML(InformationElements rootElement)
        {
            rootElements = rootElement;
        }

        public void PrintChild(InformationElements node, string path)
        {
            path += "-" + node.tag;
            if (node.element != null)
            {
                Console.WriteLine("{0}-{1}", path, node.element);
            }
  
            node.children.Sort();
            for (int i = 0; i < node.children.Count; i++)
            {
                PrintChild(node.children[i], path);
            }
        }
   
        public void Print()
        {
            PrintChild(rootElements, "");
        }
    }
}
