using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARED MISC VARIABLES FOR NEATNESS SAKE
            ConsoleKeyInfo keyselect;
            bool quit = true;
            string relay;




            //declaring class instances for the pets
            VirtualPetShelter shelter = new VirtualPetShelter("Funny Farm");
            Big_Dog carl = new Big_Dog("carl");
            Big_Dog hardee = new Big_Dog("hardee");
            SmallDog carlsjr = new SmallDog("carlsjr");
            SmallDog hardeesjr = new SmallDog("hardeesjr");
            shelter.PetAdd(carl); // adding them to the list in VirtualPetShelter as required
            shelter.PetAdd(hardee);
            shelter.PetAdd(carlsjr);
            shelter.PetAdd(hardeesjr);



            //UI START
 // TITLE CARD
            Console.WriteLine("Welcome to the  Virtual Pet Shelter Control Console TM. \n Press any key to begin.");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.WriteLine("Which Type of user are you? \n [1] VOLUNTEER \n [2] MANAGER \n SELECT AN OPTION OR PRESS Q TO QUIT");

                keyselect = Console.ReadKey();

                switch (keyselect.KeyChar)
                {
// VOLUNTEER CODE
                    case '1':  
                        Console.Clear();
                        Console.WriteLine("What is your Name?");
                        relay = Console.ReadLine();
                            Console.WriteLine("What is your specialty \n [1] Feeding \n [2] Watering \n [3] Entertaining");
                            keyselect = Console.ReadKey();
                        Volunteer volun = new Volunteer(relay, keyselect.KeyChar); // declaring volunteer class with name and expertise input
                        shelter.ShelterEmployee.Add(volun);
                        

                        do
// prints out the pet status
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome {0} the current pets availible are:", volun.Name);
                            Console.WriteLine("Name:   HungerLVL    ThirstLVL   BoredomLVL");
                            foreach (VirtualPet pet in shelter.ShelterPets) // prints the list of pets and their status
                            {
                                Console.Write(pet.Name);
                                for (int i = 0; i < 9 - pet.Name.Length; i++) // this loop makes the ui look cool and spaced evenly while in double digits at least
                                {
                                    Console.Write(" ");
                                }

                                Console.WriteLine("     {0}            {1}            {2}", pet.Hunger, pet.Thirst, pet.Boredom);
                            }

// ACTIONS CHOICE FOR VOLUNTEER
                            Console.WriteLine("\n \n \n What action would you like to partake"); 
                            Console.WriteLine(" [1] Feed All Pets \n [2] Water All Pets \n [3] Play With a Pet \n [4] Go back");
                            keyselect = Console.ReadKey();
                            switch (keyselect.KeyChar)
                            {
                                case '1': // feed
                                    volun.Feed(shelter);
                                    break;
                                case '2': // water
                                    volun.Water(shelter);
                                    break;
                                case '3': // play
                                    do
                                    {
                                        int counter = 1;
                                        Console.WriteLine("Which pet do you want to play with?");
                                        foreach (VirtualPet pet in shelter.ShelterPets) // loop to display names and number to select
                                        {
                                            Console.WriteLine(" [{0}] {1}", counter, pet.Name);
                                            counter++;
                                        }
                                        keyselect = Console.ReadKey(); // input for play select
                                    }
                                    while (KeyCheck(keyselect.KeyChar));
                                    volun.Play(shelter, (int)Char.GetNumericValue(keyselect.KeyChar));
                                    break; // break for play
                                case '4':
                                    quit = false;
                                    break;
                            }
                        } while (quit); quit = true;
                        Console.WriteLine("test");
                        break; // volunteer break





// MANAGER CODE
                    case '2':
                        Manager manager = new Manager("Darren");
                        shelter.ShelterEmployee.Add(manager);
                        // PET STATUS DISPLAY
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome Manager the current pets availible are:");
                            Console.WriteLine("Name:   HungerLVL    ThirstLVL   BoredomLVL");
                            foreach (VirtualPet pet in shelter.ShelterPets) // prints the list of pets and their status
                            {
                                Console.Write(pet.Name);
                                for (int i = 0; i < 9 - pet.Name.Length; i++) // this loop makes the ui look cool and spaced evenly while in double digits at least
                                {
                                    Console.Write(" ");
                                }
                                Console.WriteLine("     {0}            {1}            {2}", pet.Hunger, pet.Thirst, pet.Boredom);
                            }
                            Console.WriteLine("\n \n \n What action would you like to partake");
                            Console.WriteLine(" [1] Feed All Pets \n [2] Water All Pets \n [3] Play With all Pets \n [4] Adopt \n [5] Go Back");
                            keyselect = Console.ReadKey();
                            switch (keyselect.KeyChar)
                            {
                                case '1':
                                    manager.Feed(shelter);
                                    break;
                                case '2':
                                    manager.Water(shelter);
                                    break;
                                case '3':
                                    manager.Play(shelter, 0);
                                    break;
                                case '4':
                                    int counter = 0;
                                    Console.WriteLine("Which pet would you like to adopt out? \n Current Pets Availible:");
                                    foreach (VirtualPet pet in shelter.ShelterPets)
                                    {
                                        counter++;
                                        Console.WriteLine("[{0}] {1} - {2}", counter, pet.Name, pet.Description);
                                    }
                                    Console.WriteLine("enter selection number and press enter");
                                    manager.Adopt(shelter, int.Parse(Console.ReadLine()));
                                    break;
                                case '5':
                                    quit = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        while (quit); quit = true;
                     break; // MANAGER BREAK

                    case 'q'://QUIT CODE
                        quit = false;
                        break;
                    default: // nothing
                        break;
                }
            }
            while (quit);








      
          } // main

       static  public bool KeyCheck(char key)
        {
            bool f = true;
            if (key == '1') { f = false; }
            if (key == '2') { f = false; }
            if (key == '3') { f = false; }
            if (key == '4') { f = false; }
            return f;
        }
      }//class
  }//nspace

