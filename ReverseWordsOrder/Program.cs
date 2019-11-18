using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes a string of one or more words as an argument and returns the same string, " +
                                "but with all five or more letter words reversed. " +
                                "Strings passed in consist of only letters and spaces.");

            string sentence_1 = "Reverse";
            string sentence_2 = "This is a typical sentence.";
            string sentence_3 = "The dog is big.";

            var reverser = new Reverser();
            var reverseWords_1 = reverser.ReverseOrder(sentence_1);
            var reverseWords_2 = reverser.ReverseOrder(sentence_2);
            var reverseWords_3 = reverser.ReverseOrder(sentence_3);

            Console.WriteLine(reverseWords_1);
            Console.WriteLine(reverseWords_2);
            Console.WriteLine(reverseWords_3);

            Console.ReadKey();
        }
    }
}
