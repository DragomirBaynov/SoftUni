using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = input.Select(int.Parse).ToArray();

        int min = int.MaxValue;

        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    min = numbers[j];
                    numbers[j] =numbers[i] ;
                    numbers[i] = min;

                }
            }
        }


        foreach (var item in numbers)
        {
            Console.Write("{0} ",item);
        }
       
    }
}

