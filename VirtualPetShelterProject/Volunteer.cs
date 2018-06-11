using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Volunteer : Employee
    {
        private char expertise;
        public char Expertise
        {
            get { return expertise; }
            set { expertise = value; }
        }
        public Volunteer(string nameIn, char spec)
        {
            Name = nameIn;
            EmployeeType = "Volunteer";
            Expertise = spec;
        }
        public override void Feed(VirtualPetShelter petshelter) // FEED METHOD
        {
            if (Expertise == 1) // checks expertise for bonus

            {
                foreach (VirtualPet pet in petshelter.ShelterPets)
                {
                    pet.Hunger += 45;
                    pet.Boredom -= 10;
                }
            }
            else
            {
                foreach (VirtualPet pet in petshelter.ShelterPets)
                {
                    pet.Feed();
                }
            }
        }

        public override void  Play(VirtualPetShelter petshelter, int petnum) // PLAY METHOD
        {
            petnum--;
            if (Expertise == 3) // checks expertise for bonus
            {
                petshelter.ShelterPets[petnum].Boredom += 75;
                petshelter.ShelterPets[petnum].Hunger -= 15;
                petshelter.ShelterPets[petnum].Boredom -= 15;
            }
            else
            {
                petshelter.ShelterPets[petnum].Play();
            }
        }

        public override void Water(VirtualPetShelter petshelter) // WATER METHOD
        {
          if (Expertise == 2) // checks expertise for bonus
            {
                foreach (VirtualPet pet in petshelter.ShelterPets)
                {
                    pet.Thirst += 45;
                    pet.Boredom -= 10;
                }
}
            else
            {
                foreach (VirtualPet pet in petshelter.ShelterPets)
                {
                    pet.Drink();
                }
            }
        }
    }
}
