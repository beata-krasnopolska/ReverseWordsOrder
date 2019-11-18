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
            var words = sentence.Split(' '); //.Where(c => c.Length > 5).Reverse();
            //var toReverse = words.Where(c => c.Length > 5).Reverse();
            foreach (var word in words)
            {
                if (word.Length > 5)
                {
                    char[] charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }
                else
                {
                    return word;
                }
            }
            
            var finalString = String.Join(" ", words);
            return finalString;
        }
    }
}
