using System;
namespace Inheritance
{
	public class Bird : Animal
	{

        // Create a class Bird - DONE
        // give this class 4 members that are specific to Bird - DONE
        // Set this class to inherit from your Animal Class - DONE

        public Bird()
        {
            Legs = 2;
            Skin = "feathers";
            Eyes = 2;
        }

        public string Color { get; set; }
        public string WingSpan { get; set; }
        public bool Flight { get; set; }
        public string Call { get; set; }

        

    }
}

