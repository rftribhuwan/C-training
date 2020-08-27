using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetterOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkString = "Reuben Francis Tribhuwan";
            var occurenceCalculator = new OccurrenceCalculator();
            occurenceCalculator.CalculateOccurrence(checkString);
        }
    }
}
