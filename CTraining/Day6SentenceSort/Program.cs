using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6SentenceSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is Reuben Tribhuwan and I'm glad to meet you";
            var sortClass = new SortClass();
            sortClass.SortingFunction(sentence);
        }
    }
}
