using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern.LightHTML
{
    public abstract class LightNode
    {
        public string TagName { get; set; }
        public string Text { get; set; }
        public DisplayType DisplayType { get; private set; }
        public ClosureType ClosureType { get; private set; }
        public List<string> CssClasses { get; set; }

        public LightNode(string tagName, string text, DisplayType displayType, 
            ClosureType closureType, List<string> cssClasses)
        {
            TagName = tagName;
            Text = text;
            DisplayType = displayType;
            ClosureType = closureType;
            CssClasses = cssClasses;
        }

        public string CssClassesToString()
        {
            return String.Join(" ", CssClasses);
        }

        public virtual string OuterHTML(int tabCount = 0)
        {
            string tabs = new string('\t', tabCount++);

            string output = $"{tabs}<{TagName}";
            
            if(CssClasses != null && CssClasses.Count > 0)
                output += $" class = \"{CssClassesToString()}\"";
            
            if (ClosureType == ClosureType.Unitary && Text != null)
                output = $" value = \"{Text}\">";
            else if (ClosureType == ClosureType.Closing)
                output += $">{Text}</{TagName}>";

            return output;
        }

        public virtual string InnerHTML()
        {
            return Text;
        }

        public override string ToString()
        {
            return Text;
        }

        public abstract LightNode Clone();
    }
}
