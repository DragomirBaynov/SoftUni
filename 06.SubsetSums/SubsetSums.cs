using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
///  The majority of this solution is copied from colleague
/// </summary>
class SubsetSums
{
    private static int[] input;
    private static int n;
    private static bool result;

    private static void MakeSubset(int index, List<int> subset)
    {
        int sum = subset.Sum();
        if (sum == n)
        {
            PrintSubset(subset);
            result = true; 
        }

        if (subset.Count == input.Length) 
            return; 

        for (int i = index; i < input.Length; i++)
        {
            subset.Add(input[i]); 

            MakeSubset(i + 1, subset); 
            subset.RemoveAt(subset.Count - 1); 
        }

    }


    private static void PrintSubset(List<int> subset)
    {
        Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), n);
    }


    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> subset = new List<int>();
        MakeSubset(0, subset);


        if (!result)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

