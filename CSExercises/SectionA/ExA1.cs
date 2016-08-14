using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{

    //Write a program that will print out your detail in the following format:
    //Line 1: Name
    //Line 2: Email

    //Example:
    //John Smith
    //e0011223 @u.nus.edu

    public class ExA1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please Enter Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Email :");
            string email = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(email);
        }
    }
}
