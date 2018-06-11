using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class SmallDog :VirtualPet
    {
        public SmallDog()
        {
            DogType = "small dog";
            Diet = "small dog food";
            Description = "A small happy dog";
        }
        public SmallDog(string nameIn)
        {
            DogType = "small dog";
            Diet = "small dog food";
            Name = nameIn;
            Boredom = 40;
            Thirst = 50;
            Hunger = 50;

        }



    }
}
