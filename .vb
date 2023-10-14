using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            // ACT 1 

            //Initialize variables
            string name = "Laika Ria Lamigas";
            string ageString = "19";
            string address = "123 Muntinlupa City";

            //Convert age from string to int
            int age = Convert.ToInt32(ageString);

            //Print out converted values
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);

            Console.WriteLine("");
            Console.WriteLine("******************************");
            // ACT2 

            Console.WriteLine("Enter your age:");
            int AGE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + AGE);
        }
    }
}
