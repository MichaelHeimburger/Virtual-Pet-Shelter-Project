using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class VirtualPet
    {
        //fields
        public int hunger;
        public int thirst;
        public int boredom;
        public string name;
        public string description;
        public string diet;
        public string dogType;
        //properties
        public string DogType
        {
            get { return this.dogType; }
            set { this.dogType = value; }
        }
        public string Diet
        {
            get { return this.diet; }
            set { this.diet = value;}
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        //Constructiors
        public VirtualPet(string nameIn, string desc)
        {
            Name = nameIn;
            Description = desc;
        }
        public VirtualPet(string nameIn, string desc,int hung, int bore )
        {
            Name = nameIn;
            Description = desc;
            Boredom = bore;
            Hunger = hung;
        }
        public VirtualPet()
        {

        }

        //Methods
        public void Feed()
        {
            hunger += 35;
            boredom -= 10;
        }
        public void Drink()
        {
            this.thirst += 35;
            this.boredom -= 10;
        }
        public void Play()
        {
            this.boredom += 55;
            this.hunger -= 15;
            this.thirst -= 15;
        }
        public void Tick()
        {
            this.boredom -= 5;
            this.hunger -= 5;
            this.thirst -= 5;
        }

    }
}
