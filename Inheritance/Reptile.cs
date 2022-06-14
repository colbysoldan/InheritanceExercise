using System;
namespace Inheritance
{
    // Create a class Reptile - DONE
    // give this class 4 members that are specific to Reptile - DONE
    // Set this class to inherit from your Animal Class - DONE

    public class Reptile : Animal
    {
        public Reptile()
        {
            Skin = "scales";
            Eyes = 2;
        }

        public string Color { get; set; }
        public bool Venomous { get; set; }
        public bool Terrestrial { get; set; }
        public bool LiveBirth { get; set; }
    }
}

