using ComposerPattern.LightHTML;
using ComposerPattern.LightHTML.HelperClasses;

//LightElementNode mainParent =
//    new LightElementNode("div", "Main parent div", DisplayType.Block, new List<string>() { "block", "wrapper" });

//LightTextNode child1 = new LightTextNode("p", "Some text", new List<string>() { "text", "p" });
//mainParent.AppendChild(child1);

//LightTextNode child2 = new LightTextNode("p", "Under text", new List<string>() { "text", "small-text" });
//mainParent.AppendChild(child2);

//LightElementNode parent = new LightElementNode("div", "Parent div", DisplayType.Block, new List<string>() { "block", "child-parent" });
//mainParent.AppendChild(parent);

//parent.AppendChild(child1);

//LightElementNode mainParentClone = (mainParent.Clone() as LightElementNode)!;
//mainParentClone.ReplaceChild(0);

//Console.WriteLine(mainParent.OuterHTML());


TextWebLoader loader = new TextWebLoader("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");
string text = loader.GetText();

LightParser parser = new LightParser();
LightElementNode node = parser.GetLightHTML(text);

Console.WriteLine(node.OuterHTML());