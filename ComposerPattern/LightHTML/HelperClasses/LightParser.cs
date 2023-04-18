using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern.LightHTML.HelperClasses
{
    public class LightParser
    {
        private LightHTMLFactory _factory;

        public LightParser()
        {
            _factory = new LightHTMLFactory();
        }

        public LightElementNode GetLightHTML(string text)
        {
            text = text.Replace("\r", "");
            
            string[] lines = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            LightElementNode lightElementNode = new LightElementNode("div", null, DisplayType.Block, null);

            for(int i = 0; i < lines.Length; i++)
            {
                string tagName = String.Empty;

                if (i == 0)
                    tagName = "h1";
                else if (lines[i].Length < 20)
                    tagName = "h2";
                else if (lines[i][0] == ' ')
                    tagName = "blockquote";
                else
                    tagName = "p";

                lightElementNode.AppendChild(_factory.TextNode(tagName, lines[i], null));
            }
            return lightElementNode;
        }
    }
}
