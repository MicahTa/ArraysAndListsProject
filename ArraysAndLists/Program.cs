using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create arrays
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            

            // Sort
            foreach (int i in numbers) {
                if (i % 2 == 0) {
                    evens.Add(i);
                } else {
                    odds.Add(i);
                }
            }

            // List all evens
            Console.WriteLine("All evens");
            foreach (int i in evens) {
                Console.Write($"{i} ");
            }
            
            // List all odds
            Console.WriteLine("");
            Console.WriteLine("All odds");
            foreach (int i in odds) {
                Console.Write($"{i} ");
            }
        }
    }
}
