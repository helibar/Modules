using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicXml
{
    public class DynamicXElement : DynamicObject
    {
        private readonly XElement _element;

        private DynamicXElement(XElement xel)
        {
            _element = xel;
        }

        public static dynamic Create(XElement xel)
        {
            dynamic dynamicObject = new DynamicXElement(xel);
            return dynamicObject;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var node = _element.Element(binder.Name);
            if (node != null)
            {
                result = new DynamicXElement(node);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            try
            {
                if (indexes.Length != 2) throw new Exception();
                string nodeName = indexes[0] as string;
                int index = (int)indexes[1];

                var children = _element.Elements(nodeName);

                foreach (var child in children)
                {
                    if (child.ElementsBeforeSelf(nodeName).Count() == index)
                    {
                        result = new DynamicXElement(child);
                        return true;
                    }
                }

                result = null;
                return false;
            }
            catch
            {
                result = null;
                return false;
            }
        }
        public override string ToString()
        {
            var source = _element;
            if (source.Name=="Planet") source = _element.Element("Name");
            return source.Value.ToString();
        }

    }
}
