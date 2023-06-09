﻿using ComposerPattern.LightHTML.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ComposerPattern.LightHTML
{
    public class LightTextNode : LightNode
    {
        public LightTextNode(string tagName, string text, List<string> cssClasses) : 
            base(tagName, text, DisplayType.Row, ClosureType.Closing, cssClasses)
        {
        }

        public override LightNode Clone()
        {
            return new LightTextNode(TagName,Text, (CssClasses.Clone() as List<string>)!);
        }
    }
}
