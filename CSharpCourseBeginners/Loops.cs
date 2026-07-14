using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseBeginners
{
    public class Loops
    {
        public static void LoopsLearning()
        {
            // for loop
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }

            // while loop
            bool myBool = true;

            int number = 1;

            while (myBool == false)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}
