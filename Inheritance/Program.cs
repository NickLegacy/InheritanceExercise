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
            Bird Birdy = new Bird()
            {
                Name = "Big Bird",
                Age = 50,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "Yellow",
            };

            Console.WriteLine($"{Birdy.Name} is {Birdy.Age} years old. He has {Birdy.Legs} legs and also {Birdy.Wings} wings. He has a backbone," +
            $" he is warmblooded and also has feathers that are {Birdy.Type}.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                Name = "Fire Dragon",
                Age = 1200,
                Legs = 4,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Fire Relm",
                Defense = "breath fire"
            };

            Console.WriteLine($"The {dragon.Name} has lived for over {dragon.Age} years. He has {dragon.Legs} legs, a backbone, and scales." +
            $" Even though he is cold blooded, he is able to {dragon.Defense}. He lives in the {dragon.Environment}."); 

}
          
}
}
