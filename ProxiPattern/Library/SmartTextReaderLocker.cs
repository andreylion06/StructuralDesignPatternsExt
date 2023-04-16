using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProxiPattern.Library
{
    public class SmartTextReaderLocker : ITextReader
    {
        private SmartTextReader reader;
        private string regexRestriction;

        public SmartTextReaderLocker(SmartTextReader reader, string regexFileRestriction)
        {
            this.reader = reader;
            this.regexRestriction = regexFileRestriction;
        }

        public char[][] Read()
        {
            if (Regex.IsMatch(reader.fileName, regexRestriction))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return reader.Read();
        }
    }
}
