using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseBeginners
{
    public class Collections
    {
        public static void CollectionsLearning()
        {
            // arrays
            Console.WriteLine("This is the array");
            string[] fruits = { "Apple", "Banana", "Orange" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            string[] cities = { "Sydney", "Copenhagen", "London" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            // lists
            Console.WriteLine("This is the list");
            List<string> fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Banana");
            fruitList.Add("Orange");

            foreach (var fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nAdding to list...");
            Console.WriteLine("This is the new list");

            fruitList.Add("Cherry");
            fruitList.Add("Kiwi");

            foreach (var fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nRemoving from list...");
            Console.WriteLine("This is the new list");

            fruitList.Remove("Banana");

            foreach (var fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
