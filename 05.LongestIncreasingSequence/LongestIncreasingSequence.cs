using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

class LongestIncreasingSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = input.Select(int.Parse).ToArray();
        int counter = 1;
        int max = 1;
        int end = 0;

        Console.Write("{0} ",numbers[0] );

        for (int i = 1; i <= numbers.Length-1; i++)
        {
            
            if (numbers[i] >numbers[i-1])
            {
                counter++;
                Console.Write("{0} ",numbers[i] );
            }

            else
            {
                counter = 1;
                Console.WriteLine(  );
                Console.Write("{0} ",numbers[i] );
            }

            if (counter > max)
            {
                max = counter;
                end = i+1;
            }


        }
        Console.WriteLine();
        //Console.WriteLine( max );
        //Console.WriteLine( end );
        Console.Write( "Longest: " );
        for (int i = end-max; i < end; i++)
        {
            Console.Write("{0} ",numbers[i]  );
        }
        Console.WriteLine();
    }
}

