using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird pidgey = new Bird()
            {
                Name = "Pidgey",
                Age = 12,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "Flying",
            };

            Console.WriteLine($"{pidgey.Name} is a {pidgey.Type} pokemon that is {pidgey.Age} years old and has " +
                $"{pidgey.Legs} legs and {pidgey.Wings} wings.");
            Console.WriteLine($"Is {pidgey.Name} a vertebrate, warm blooded, and have feathers?" +
                $"{pidgey.HasBackbone}, {pidgey.IsWarmBlooded}, and {pidgey.HasFeathers}");
            Console.WriteLine();

            Reptile charizard = new Reptile()
            {
                Name = "Charizard",
                Age = 42,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Type = "Fire",
                Defense = "breathes fire"
            };

            Console.WriteLine($"{charizard.Name} is a {charizard.Type} pokemon that is {charizard.Age} years old and " +
                $"{charizard.Defense} to defend himself.");
            Console.WriteLine($"Is {charizard.Name} a vertebrate, cole blooded, and has scales?" +
                $"{charizard.HasBackbone}, {charizard.IsColdBlooded}, and {charizard.HasScales}");
            Console.WriteLine();

        }
    }
}
