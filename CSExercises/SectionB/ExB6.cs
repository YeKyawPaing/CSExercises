using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer for X1");
            int x1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter an integer for Y1");
            int y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter an integer for X2");
            int x2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter an integer for Y2");
            int y2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("{0}", CalculateDistance(x1, y1, x2, y2));
        }

        public static double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
