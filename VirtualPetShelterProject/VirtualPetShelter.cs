using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{




    class VirtualPetShelter
    {
        private List<Employee> shelterEmployee = new List<Employee>();
        private List<VirtualPet> shelterPets = new List<VirtualPet>();
        private string name;

        public List<VirtualPet> ShelterPets
        {
            get { return shelterPets; }
            set { shelterPets = value; }
        }
        public List<Employee> ShelterEmployee
        {
            get { return shelterEmployee; }
            set { shelterEmployee = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public VirtualPetShelter()
        {

        }
        public VirtualPetShelter(string nameIn)
        {
            Name = nameIn;
        }

        public void PetAdd(VirtualPet pet)
        {
            ShelterPets.Add(pet);
        }

        public void EmployeeAdd(Employee man)
        {
            ShelterEmployee.Add(man);
        }

        public void PetRemove(VirtualPet pet)
        {
            ShelterPets.Remove(pet);
        }

 








    }





}
