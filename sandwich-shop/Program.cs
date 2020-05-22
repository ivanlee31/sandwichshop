using System;
using System.Collections.Generic;

namespace sandwich_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List1 = new List<string>();
            List<string> List2 = new List<string>();
            List<string> Listbread = new List<string>() { "plain bread", "white bread", "wholemeal" };
            List<string> Listmeat = new List<string>() { "beef", "chicken", "pork", "fish" };
            List<string> Listoption = new List<string>() { "Carrot", "Cucumber", "Tomato", "Potato", "Letuce", "Onion", "Cheese" };
            List<string> Listdrinks = new List<string>() { "Coke", "Sprite", "Mountain dew", "Fanta" };



            Console.WriteLine("hi whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to our shop " + name + ", what bread do you like ? we have white bread, plain bread, or wholemeal ");

            string bread = Console.ReadLine();

            if
                (bread == "white bread" || bread == "plain bread")
            {

                Console.WriteLine("what meat would you like ?beef/chicken/pork/fish");
                Console.ReadLine() 

               
            }
            else if ( bread == "wholemeal")
            {
                Console.WriteLine("what drinks do you like " + name);

            }
            else
            {
                while (bread != "white bread" || bread != "plain bread" || bread != "wholemeal")
                {
                    Console.WriteLine("we dont have that " + name + " please choose from above");
                    bread = Console.ReadLine();
                }





            }
           


        }
    }
}
