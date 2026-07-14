using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseBeginners
{
    public class Variables
    {
        public static void VariablesLearning()
        {
            Console.WriteLine("Hello. What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Hello. Where are you from?");

            string country = Console.ReadLine();

            Console.WriteLine("I have heard great things about people from " + country);

            Console.WriteLine("How old are you?");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);

            //// string = a piece of text
            //string myName = "DevMan";

            //// integer (int) = whole number, 1 2 3 4 5
            //int myNumber = 3;

            //// float = is a number with a decimal
            //float myDecimalNumber = 1.5f;

            //// bool = true or false
            //bool myBool = false;
        }
    }
}
