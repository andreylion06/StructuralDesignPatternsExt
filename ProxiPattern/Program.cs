using ProxiPattern.Library;

var reader = new SmartTextReader("test.txt");
var checker = new SmartTextChecker(reader);
var locker = new SmartTextReaderLocker(reader, ".txt3");

//var text = checker.Read();

var text = locker.Read();


if(text != null)
{
    foreach (var row in text)
        Console.WriteLine(new string(row));
}

