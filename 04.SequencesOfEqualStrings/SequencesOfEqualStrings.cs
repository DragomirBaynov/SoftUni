using System;


namespace _04.SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int counter = 0;
            int Best = 0;
            Console.WriteLine();
            for (int i = 0; i <= input.Length-1; i++)
            {
                Console.Write("{0} ", input[i]);
                if (i == input.Length-1)
                {
                    break;
                }
                if (input[i] != input[i+1])
                {
                    Console.WriteLine();
                }
               
                
            }
            Console.WriteLine();
        }
    }
}
