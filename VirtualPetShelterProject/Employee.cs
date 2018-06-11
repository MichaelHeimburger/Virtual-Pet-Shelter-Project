using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    abstract class Employee
    {
        private string employeeType;
        private string name;
        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract void Play(VirtualPetShelter pet, int petnum);

        public abstract void Feed(VirtualPetShelter pet);

        public abstract void Water(VirtualPetShelter pet);






    }

}

