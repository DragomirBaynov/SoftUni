using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
      int[] sorted = new int[input.Length];
      int i = 0;
        foreach (var item in input)
        {
            sorted[i] = int.Parse(item);
            i++;
            
        }
        Array.Sort(sorted);
        foreach (var item in sorted)
        {
            Console.Write("{0} ",item);
        }
    }
}

