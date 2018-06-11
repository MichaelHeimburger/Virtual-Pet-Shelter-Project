using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Big_Dog : VirtualPet
    {
        

        public Big_Dog()
        {
            DogType = "Big Dog";
            Diet = "Big Dog food";
            Description = "A big happy dog";
        }
        public Big_Dog(string nameIn)
        {
            DogType = "Big Dog";
            Diet = "Big Dog food";
            Name = nameIn;
            Boredom = 70;
            Thirst = 10;
            Hunger = 10;
        }


    }
}
