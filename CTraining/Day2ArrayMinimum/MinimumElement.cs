using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinimum
    {
        class MinimumElement
        {
            public int FindMinimum(int[] array, int numberOfElements)
            {
                int i;
                int smallestNumber = array[0];
                for (i = 1; i < numberOfElements; i++)
                {
                    if (array[i] < smallestNumber)
                        smallestNumber = array[i];
                }
                return smallestNumber;
            }
        }
    }
