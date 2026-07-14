using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseBeginners
{
    public class Conditions
    {
        public static void Conditionslearning()
        {
            Console.WriteLine("Welcome to the ticket office. What is your age?");

            int age = Convert.ToInt32(Console.ReadLine());

            // if
            if (age < 18)
            {
                Console.WriteLine("You are a youth. Your ticket price is $5");
            }

            // else if
            else if (age > 65 && age < 2000)
            {
                // senior prices
                Console.WriteLine("You are a senior. Your ticket price is $8");

            }

            else if (age > 2000)
            {
                Console.WriteLine("You are too old to be here");
            }

            // else
            else
            {
                // Adult prices
                Console.WriteLine("You are an adult. Your ticket price is $10");

            }
        }
    }
}
