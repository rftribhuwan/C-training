using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6SentenceSort
{
    class SortClass
    {
        public void SortingFunction(string sentence)
        {
            char separator = ' ';
            var words = sentence.ToLower().Split(separator);
            string temp;
            for(int j = 1; j < words.Length; j++)
            {
                for (int i = 0; i < words.Length-j; i++)
                {
                    if (string.Compare(words[i + 1], words[i]) < 0)
                    {
                        temp = words[i + 1];
                        words[i + 1] = words[i];
                        words[i] = temp;
                    }
                }
            }
            sentence = string.Join(" ", words);
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1) + ".";

            //make the first letter capital
            Console.WriteLine(sentence);
            
        }
    }
}
