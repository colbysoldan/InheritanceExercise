using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var emperorPenguin = new Bird() {
                Species = "Emperor Penguin",
                Lifespan = "15 to 20 years",
                Color = "black and white",
                Flight = false,
                WingSpan = "76 to 89 centimeters",
                Call = "loud honk",
                Habitat = "arctic",
                EngangeredStatus = "near threatened"
            };

            
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reticulatedPython = new Reptile()
            {
                Species = "Reticulated Python",
                Legs = 0,
                Lifespan = "12 to 20 years",
                Color = "brown and yellow with black diamonds",
                Habitat = "tropical forests, woodlands, grasslands",
                EngangeredStatus = "not threatened",
                Venomous = false,
                Terrestrial = true,
                LiveBirth = false
            };

            var birds = new Bird[] { emperorPenguin };
            foreach (var bird in birds)
            {
                Console.WriteLine($"{bird.Species}" +
                    $"\nLegs: {bird.Legs}" +
                    $"\nEyes: {bird.Eyes}" +
                    $"\nTexture: {bird.Skin}" +
                    $"\nLifespan: {bird.Lifespan}" +
                    $"\nHabitat: {bird.Habitat}" +
                    $"\nConservation Status: {bird.EngangeredStatus}" +
                    $"\nColor: {bird.Color}" +
                    $"\nWingspan: {bird.WingSpan}" +
                    $"\nCan fly? {bird.Flight}" +
                    $"\nCall: {bird.Call}\n\n");
            }

            var reptiles = new Reptile[] { reticulatedPython };
            foreach (var reptile in reptiles)
            {
                Console.WriteLine($"{reptile.Species}" +
                    $"\nLegs: {reptile.Legs}" +
                    $"\nEyes: {reptile.Eyes}" +
                    $"\nTexture: {reptile.Skin}" +
                    $"\nLifespan: {reptile.Lifespan}" +
                    $"\nHabitat: {reptile.Habitat}" +
                    $"\nConservation Status: {reptile.EngangeredStatus}" +
                    $"\nColor: {reptile.Color}" +
                    $"\nVenomous? {reptile.Venomous}" +
                    $"\nTerrestrial? {reptile.Terrestrial}" +
                    $"\nLive Birth? {reptile.LiveBirth}\n\n");
            }
            Console.ReadLine();
        }

    }
}
