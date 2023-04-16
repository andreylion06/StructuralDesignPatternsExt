using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxiPattern.Library
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            this.reader = reader;
        }

        public char[][] Read()
        {
            Console.WriteLine($"Opening file {reader}");
            var textArray = reader.Read();
            Console.WriteLine($"Closing file {reader}");
            Console.WriteLine($"Total lines: {textArray.Length}, Total characters: {textArray.SelectMany(row => row).Count()}");
            return textArray;
        }
    }
}
