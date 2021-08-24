using System;
using System.Collections.Generic;

namespace Channel9Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What make of car?");
            string carMake = Console.ReadLine();

            Console.WriteLine("What make of car?");
            string carModel = Console.ReadLine();

            Console.WriteLine("What make of car?");
            string carColour = Console.ReadLine();

            Console.WriteLine("What make of car?");
            DateTime yearBought = Convert.ToDateTime(Console.ReadLine());

            var Cars = new Cars(carMake, carModel, carColour, yearBought);
            
        }
    }
}
