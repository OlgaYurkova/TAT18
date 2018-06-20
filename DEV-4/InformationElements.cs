using System;
using System.Collections.Generic;

namespace task_4
{
    /// <summary>
    /// This class carries information about the elements(separation of elements)   
    /// </summary>
    class InformationElements : IComparable<InformationElements>
    {
        public List<InformationElements> children;
        public List<string> attributes;
        InformationElements parent;

        public string tag;
        public string element;

        public InformationElements(InformationElements parent, string tag, string element)
        {
            this.parent = parent;
            this.tag = tag;
            this.element = element;
            children = new List<InformationElements>();
            attributes = new List<string>();
        }

        public InformationElements AddChild(string tag, string element)
        {
            InformationElements nodeItem = new InformationElements(this, tag, element);
            int index = children.IndexOf(nodeItem);
            children.Add(nodeItem);
            return nodeItem;
        }

        public InformationElements GetParent()
        {
            return parent;
        }

        public void AddCAttributes(string value)
        {
            attributes.Add(value);
        }

        public int CompareTo(InformationElements other)
        {
            int result = tag.CompareTo(other.tag);
            if (result == 0)
            {
                if (element != null && other.element != null)
                {
                    result = element.CompareTo(other.element);
                }
            }
            return result;
        }
    }
}
