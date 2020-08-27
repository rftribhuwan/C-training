using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetterOccurrence
{
    class OccurrenceCalculator
    {
        public void CalculateOccurrence(string checkString)
        {
            int occurrence;
            StringBuilder sb = new StringBuilder(checkString);
            char singleLetter;
            for(int i =0; i<sb.Length;i++)
            {
                if(sb[i] == ' ')
                {
                    continue;
                }
                singleLetter = sb[i];
                occurrence = 0;
                for(int j=0; j<sb.Length;j++)
                {
                    if(char.ToUpper(singleLetter) == char.ToUpper(sb[j]))
                    {
                        occurrence++;
                        sb[j] = ' ';                        
                    }
                }
                Console.WriteLine($"Occurrence of '{singleLetter}' = {occurrence}");
            }
        }
    }
}
