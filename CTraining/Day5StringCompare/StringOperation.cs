using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5StringCompare
{
    class StringOperation
    {
        public void StringCompare()
        {
            try
            {
                string firstString, secondString;
                Console.WriteLine("Enter the first string");
                firstString = Console.ReadLine();
                Console.WriteLine("Enter the second string");
                secondString = Console.ReadLine();
                int result = string.Compare(firstString, secondString);
                var fileOperation = new FileOperation(firstString, secondString, result);
                fileOperation.FileOperations();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
