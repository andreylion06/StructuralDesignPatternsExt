using ComposerPattern.LightHTML.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ComposerPattern.LightHTML
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> _children;

        public LightElementNode(string tagName, string text, 
            DisplayType displayType, List<string> cssClasses) : 
            base(tagName, text, displayType, ClosureType.Closing, cssClasses)
        {
            _children = new List<LightNode>();
        }

        public LightElementNode(string tagName, string text, DisplayType displayType,
            List<string> cssClasses, List<LightNode> children) :
            base(tagName, text, displayType, ClosureType.Closing, cssClasses)
        {
            this._children = children;
        }

        public void AppendChild(LightNode node)
        {
            _children.Add(node);
        }

        public void ReplaceChild(int index)
        {
            if(index >= 0 && index < _children.Count)
                _children.RemoveAt(index);
        }

        public void InsertBefore(LightNode refNode, LightNode newNode)
        {
            int index = _children.IndexOf(refNode);
            if(index != -1)
            {
                _children.Insert(index, newNode);
            }
        }

        public override string OuterHTML(int tabCount = 0)
        {
            string tabs = new string('\t', tabCount++);

            string output = $"{tabs}<{TagName}";
            
            if(CssClasses.Count > 0) 
                output += $" class = \"{CssClassesToString()}\"";

            output += ">";

            if (Text != null || _children.Count > 0)
            {
                output += "\n";
                if (Text != null)
                    output += $"{tabs}\t{Text}\n";

                foreach (LightNode node in _children)
                    output += $"{node.OuterHTML(tabCount)}\n";

                if (_children.Count > 0)
                    output += tabs;
            }

            output += $"</{TagName}>";

            return output;
        }

        public override string InnerHTML()
        {
            if (Text != null || _children.Count > 0)
            {
                string output = String.Empty;
                if (Text != null)
                    output += $"{Text}\n";

                foreach (LightNode node in _children)
                    output += $"{node.OuterHTML()}\n";

                return output;
            }

            return String.Empty;
        }

        public override LightNode Clone()
        {
            List<LightNode> clonedChildren = new List<LightNode>();
            foreach (var child in _children)
                clonedChildren.Add(child.Clone());

            return new LightElementNode(TagName, Text, DisplayType, 
                (CssClasses.Clone() as List<string>)!, clonedChildren);
        }
    }
}