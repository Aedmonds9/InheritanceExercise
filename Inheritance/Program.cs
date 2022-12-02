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
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Bird falcon = new Bird()
            {
                Name = "Falcon",
                Age = 5,
                Legs = 2,
                HasBackbone = true,
                FeatherColor = "Brown",
                Wings = 2,
                Migrates = true,
                Type = "Large",
            };
            Console.WriteLine($"{falcon.Name} is a {falcon.Age} year old {falcon.Type} {falcon.Name}. These birds usually have {falcon.Legs} legs, {falcon.Wings} wings and {falcon.FeatherColor} feathers.");

            Reptile komodo = new Reptile()
            {
                Name = "Komodo",
                Age = 22,
                Legs = 4,
                HasBackbone= true,
                Climate = "Tropical",
                ColdBlooded = true,
                Size =  "Large",
                HasScales = true,
            };
            Console.WriteLine($"{komodo.Name}'s are a {komodo.Size} type of reptile usually found in {komodo.Climate} climates. They can live for 80+ years, although this one is only {komodo.Age} years old.");
        }
    }
}
