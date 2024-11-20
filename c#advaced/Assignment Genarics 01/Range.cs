using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Genarics_01
{ //2.1
    internal class Range<T> where T : IComparable<T>
    {
        
            public T Min { get; }
            public T Max { get; }

            public Range(T min, T max)
            {
            Min = min;
            Max = max;
                if (min.CompareTo(max) > 0)
                {
                Console.WriteLine(  "the min valua of a max valua");
            }

               
            }

            public bool Contains(T value)
            {
                return Min.CompareTo(value) == 0 && Max.CompareTo(value) == 0;
            }

         
            }
        
    }

