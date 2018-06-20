using System;
using System.Collections.Generic;
using System.IO;

namespace task_4
{
    /// <summary>
    /// Class's removes unnecessary tags in XML files
    /// </summary>
    class XmlParser
    {
        public enum ItemTypes
        {
            OpenTag,
            CloseTag,
            ToSkip,
            Undefined
        }

        public class ParsedItem
        {
            public ItemTypes types;
            public string tag;
            public string element;
            public List<Tuple<string, string>> attr;
        }          
        
        private InformationElements rootElementt;
        private string fileName;

        public XmlParser(string fileName, InformationElements rootElementt)
        {
            this.fileName = fileName;
            this.rootElementt = rootElementt;
        }

        public ParsedItem FindItem(string s)
        {
            ParsedItem result = new ParsedItem();
            int start = s.IndexOf('<') + 1;
            if (s[start] == '?')
            {
                result.types = ItemTypes.ToSkip;
            }
            else if (s[start] == '/')
            {
                result.types = ItemTypes.CloseTag;
            }
            else
            {
                result.types = ItemTypes.OpenTag;

                int closingBPos = s.IndexOf('>');
                int end = s.Substring(start, closingBPos - start + 1).IndexOf(' ');
                if (end < 0)
                {
                    end = closingBPos - 1;
                }
                result.tag = s.Substring(start, end - start + 1).Trim();

                string rest = s.Substring(closingBPos + 1).Trim();
                int nextStart = rest.IndexOf('<');
                if (nextStart > 0)
                {
                    result.element = rest.Substring(0, nextStart);
                }
            }
            return result;
        }

        public void Parse()
        {
            StreamReader streamReader = new StreamReader(fileName);
            string xmlLines = streamReader.ReadToEnd();
            InformationElements currentNode = rootElementt;
            while (xmlLines.Length > 0)
            {
                ParsedItem parsedItem = FindItem(xmlLines);
                switch (parsedItem.types)
                {
                    case ItemTypes.OpenTag:
                        currentNode = currentNode.AddChild(parsedItem.tag, parsedItem.element);
                        break;

                    case ItemTypes.CloseTag:
                        currentNode = currentNode.GetParent();
                        break;

                    case ItemTypes.ToSkip:
                        break;
                }
                int nextTag = xmlLines.IndexOf('<', 1);
                if (nextTag < 0)
                {
                    break;
                }
                xmlLines = xmlLines.Substring(nextTag);
            }
        }
    }
}
