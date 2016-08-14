using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            string str = Console.ReadLine();
            double d = Convert.ToDouble(str);

            Console.WriteLine("{0:#.###}",SQRT(d));
        }

        public static double SQRT(double d2)
        {
            d2 = Math.Sqrt(d2);
            return d2;

        }
    }
}
