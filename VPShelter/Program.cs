using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            //volunteer methods working on animals bools??
            //Dog Muffin = new Dog();
            //EmployeeClass pete = new EmployeeClass();
            //pete.Feed(Muffin.IsHungry);

            //instantiate new object of VPS in order to be able to call methods from that class to print lists of anmials"
            VirtualPetShelter juliesVPShelter = new VirtualPetShelter();

            //instantiate all lists so that I can fill them with obejcts:
            List<Dog> AllDogs = new List<Dog>();
            List<Cat> AllCats = new List<Cat>();
            List<Volunteer> AllVolunteers = new List<Volunteer>();
            List<Manager> AllManagers = new List<Manager>();

            //link lists to the property that is in VPS class:
            juliesVPShelter.AllCats = AllCats;
            juliesVPShelter.AllDogs = AllDogs;
            juliesVPShelter.AllVolunteers = AllVolunteers;
            juliesVPShelter.AllManagers = AllManagers;

            //instantiating 3 new dogs to live in the shelter and adding them each to the list as they're created.
            Dog daisy = new Dog("Daisy", 12);
            AllDogs.Add(daisy);
            Dog trixie = new Dog("Trixie", 7);
            AllDogs.Add(trixie);
            Dog opie = new Dog("Opie", 8);
            AllDogs.Add(opie);

            //instantiating 3 new cats to live in the shelter and adding them each to the cat list:
            Cat buttons = new Cat("Buttons", 4);
            AllCats.Add(buttons);
            Cat bearCat = new Cat("Bearcat", 2);
            AllCats.Add(bearCat);
            Cat gucci = new Cat("Gucci", 12);
            AllCats.Add(gucci);

            //instantiating 3 volunteers and adding them to the list:
            Volunteer ramona = new Volunteer("Ramona", 7, 2);
            AllVolunteers.Add(ramona);
            Volunteer allen = new Volunteer("Allen", 3, 1);
            AllVolunteers.Add(allen);
            Volunteer sam = new Volunteer("Sam", 10, 5);
            AllVolunteers.Add(sam);

            //instantiating 3 managers and adding them to the list:
            Manager julie = new Manager();
            AllManagers.Add(julie);
            Manager austin = new Manager();
            AllManagers.Add(austin);
            Manager robin = new Manager();
            AllManagers.Add(robin);

            

            //greeting for the program:
            Console.WriteLine("Welcome to Julie's Pet Shelter where the pets are happy!" +
                "\nTo log in, please type \"1\" for Manager and \"2\" for volunteer.");
            int userChoice = int.Parse(Console.ReadLine());

            //manager choice/menu:
            if (userChoice == 1)
            {
                int managerChoice;
                do
                {
                    Console.WriteLine("\nManager Menu:");
                    Console.WriteLine("Punch in: 1");
                    Console.WriteLine("Punch out: 2");
                    Console.WriteLine("Host a volunteer training: 3");
                    Console.WriteLine("Host a pet adoption: 4");
                    Console.WriteLine("View a roster: 5");
                    Console.WriteLine("View Volunteer Experience Level: 6");
                    Console.WriteLine("View animals statuses: 7");
                    Console.WriteLine("Exit program: 0");
                    managerChoice = int.Parse(Console.ReadLine());

                    switch (managerChoice)
                    {
                        case 1:
                            //call check in method
                            break;

                        case 2:
                            //call check out method
                            break;

                        case 3:
                            //call trianing method
                            break;

                        case 4:
                            //call adoption method
                            break;

                        case 5:
                            //options to view all rosters, call those methods
                            foreach(string name in juliesVPShelter.DogRoster())
                            {
                                Console.WriteLine(name);
                            }
                            break;

                        case 6:
                            //create method to view vol exp level
                            break;

                        case 7:
                            //create method to view animal status
                            break;

                        case 0:
                            break;

                        default:
                            Console.WriteLine("Please select a valid choice.");
                            break;
                    }
                } while (managerChoice != 0);
            }

            //volunteer choice/menu:
            else if (userChoice == 2)
            {
                int volChoice;
                do
                {
                    Console.WriteLine("\nVolunteer Menu:");
                    Console.WriteLine("Sign in: 1");
                    Console.WriteLine("Sign out: 2");
                    Console.WriteLine("Attend a volunteer training: 3");
                    Console.WriteLine("View animal statuses: 4");
                    Console.WriteLine("Clean cages: 5");
                    Console.WriteLine("Feed animals: 6");
                    Console.WriteLine("Water animals: 7:");
                    Console.WriteLine("Exit program: 0");

                    volChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            //checkin method
                            break;

                        case 2:
                            //check out method
                            break;

                        case 3:
                            //training method
                            break;

                        case 4:
                            //need to make animal status method
                            break;

                        case 5:
                            //clean cage method (on which pet?)
                            break;

                        case 6:
                            //feed animal method(on which pet?)
                            break;

                        case 7:
                            //water animal method (on which pet?)
                            break;


                        case 0:
                            break;

                        default:
                            Console.WriteLine("Please select a valid choice.");
                            break;
                    }
                } while (volChoice != 0);
                }
            else
                Console.WriteLine("Please enter a valid response.");
        }
    }
}
