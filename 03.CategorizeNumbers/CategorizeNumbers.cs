using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CategorizeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<double> numbers = input.Select(double.Parse).ToList();
        List<int> rounds = new List<int>();
        List<double> floating = new List<double>();


        foreach (var item in input)
        {           
                floating.Add(double.Parse(item));            
        }

        foreach (var item in floating)
        {
            if (item % 1 == 0 )
            {
                rounds.Add((int)item);
                numbers.Remove(item);
            }
        }

        Console.WriteLine();
        Console.Write("[ ");
        foreach (var item in numbers)
        {
            Console.Write("{0}  ",item);
        }
        Console.Write("] -> min: {0:f2}, max: {1:f2}, sum : {2:f2}, avg: {3:f2} ",numbers.Min(),numbers.Max(),numbers.Sum(),numbers.Average());
        Console.WriteLine();

        Console.Write("[ ");
        foreach (var item in rounds)
        {
            Console.Write("{0} ", item);
        }
        Console.Write("] -> min: {0}, max: {1}, sum : {2:f2}, avg: {3:f2} ",rounds.Min(), rounds.Max(), rounds.Sum(), rounds.Average());
        Console.WriteLine( );
        Console.WriteLine();

    }
}

