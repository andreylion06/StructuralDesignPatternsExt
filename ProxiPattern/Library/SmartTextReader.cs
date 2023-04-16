using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxiPattern.Library
{
    public class SmartTextReader : ITextReader
    {
        public string fileName;

        public SmartTextReader(string fileName)
        {
            this.fileName = fileName;
        }

        public char[][] Read()
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"File {fileName} not found!");
            }

            var lines = File.ReadAllLines(fileName);
            var textArray = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                textArray[i] = lines[i].ToCharArray();
            }

            return textArray;
        }
    }
}
