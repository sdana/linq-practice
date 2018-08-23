using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            List<string> LFruits = (from fruit in fruits select fruit).Where(fruit => fruit[0].ToString() == "L").ToList();
            foreach (string fruit in LFruits)
            {
            System.Console.WriteLine(fruit);
                
            }
        }
    }
}
