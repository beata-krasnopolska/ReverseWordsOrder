using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsOrder
{
    class Reverser
    {
        public string ReverseOrder(string sentence)
        {
            var words = sentence.Split(' ');

            string text = string.Empty;

            foreach (var word in words)
            {
                if (word.Length > 5)
                {
                    text += string.Concat(word.Reverse()) + " ";
                    continue;
                }
                text += word + " ";
            }
            return text;
        }
    }
}
