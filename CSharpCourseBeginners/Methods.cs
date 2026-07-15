using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseBeginners
{
    public class Methods
    {
        public static void MethodsLearning()
        {
            //Console.WriteLine("Press enter to make me repeat myself");

            //Console.ReadKey();

            //for (int i = 0; i < 5; i++)
            //{
            //    PressEnterToRepeat();
            //}

            Console.WriteLine("Lets's add numbers");
            Console.WriteLine(Add(5, 5));

            Console.WriteLine("");

            Console.WriteLine("Let's subtract numbers");
            Console.WriteLine(Subtraction(5, 5));

            Console.WriteLine("");

            Console.WriteLine("Let's divide numbers");
            Console.WriteLine(Division(5, 5));

            Console.WriteLine("");

            Console.WriteLine("Let's multiply numbers");
            Console.WriteLine(Multiply(5, 5));
        }

        //static void PressEnterToRepeat()
        //{
        //    Console.WriteLine("You pressed enter");
        //    Console.WriteLine("Press enter to make me repeat myself");
        //    Console.ReadKey();
        //}

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtraction(int x, int y)
        {
            return x - y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
