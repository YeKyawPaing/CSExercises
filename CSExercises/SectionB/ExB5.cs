﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer for x");
            string str = Console.ReadLine();
            int x = Convert.ToInt16(str);
            Console.WriteLine("{0}", CalculateY(x));
        }

        public static int CalculateY(int x)
        {
            int y = 5 * x * x - 4 * x + 3;
            return y;
        }
    }
}
