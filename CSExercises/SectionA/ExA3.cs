using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);

            int result = square(i);
            Console.WriteLine(result);
        }

        public static int square(int x)
        {
            x = (int)Math.Pow(x, 2);
            return x;

        }
    }
}
