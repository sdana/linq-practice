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


                    // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(number => (number % 4 == 0) || (number % 6 == 0)).ToList();
            foreach (int number in fourSixMultiples)
            {
                System.Console.WriteLine($"{number} is divisble by either 4 or 6");
            }


            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = from name in names
                orderby name descending
                select name;

            List<string> namesInOrder = new List<string>();
            foreach (string name in descend)
            {
                namesInOrder.Add(name);
            }
            System.Console.WriteLine(String.Join(",", namesInOrder));


                List<int> numbersList = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> sortedNumbers = from number in numbersList
                orderby number ascending
                select number;

            foreach (int number in sortedNumbers)
            {
                System.Console.WriteLine(number);
            }

            // Output how many numbers are in this list
        List<int> numbersList2 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        int howMany = numbersList2.Count();
        System.Console.WriteLine(howMany);
        }
    }
}
