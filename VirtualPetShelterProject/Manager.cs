using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Manager : Employee
    {
        private int wageAnHour;

        public int WageAnHour
        {
            get { return wageAnHour; }
            set { wageAnHour = value; }
        }
        public Manager(string name)
        {
            Name = name;
            EmployeeType = "Manager";
            WageAnHour = 12;
        }
        public void Adopt(VirtualPetShelter petShelter, int petNum) // adopt method
        {
            petNum--;
            petShelter.ShelterPets.RemoveAt(petNum);
        }

        public override void Play(VirtualPetShelter petshelter, int petnum) // play method
        {
            foreach (VirtualPet pet in petshelter.ShelterPets)
            {
                pet.Play();
            }
        }

        public override void Feed(VirtualPetShelter petshelter) // feed method
        {
            foreach (VirtualPet pet in petshelter.ShelterPets)
            {
                pet.Feed();
            }
        }

        public override void Water(VirtualPetShelter petshelter) //watermethod
        {
            foreach (VirtualPet pet in petshelter.ShelterPets)
            {
                pet.Drink();
            }
        }
    }
}
