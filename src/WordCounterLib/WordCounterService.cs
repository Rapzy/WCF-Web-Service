using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WordCounterLib
{
    public class WordCounterService : IWordCounter
    {
        public int CountWords(string text)
        {
            int index = 0, wordCount = 0;
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;
            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            return wordCount;
        }
    }
}
