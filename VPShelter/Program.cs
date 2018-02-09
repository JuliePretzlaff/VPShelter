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
            /////on which pet?
            //animal status show
            /////for all animals
            //test
            //make sure requirements are met

            //example on how to call a method...might need this.
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
            Dog daisy = new Dog("Daisy", 12, "fluffy");
            AllDogs.Add(daisy);
            Dog trixie = new Dog("Trixie", 7, "excited");
            AllDogs.Add(trixie);
            Dog opie = new Dog("Opie", 8, "cuddly");
            AllDogs.Add(opie);

            //instantiating 3 new cats to live in the shelter and adding them each to the cat list:
            Cat buttons = new Cat("Buttons", 4, "serpent-like");
            AllCats.Add(buttons);
            Cat bearCat = new Cat("Bearcat", 2, "a nusence");
            AllCats.Add(bearCat);
            Cat gucci = new Cat("Gucci", 12, "friendly");
            AllCats.Add(gucci);

            //instantiating 3 volunteers and adding them to the list:
            Volunteer ramona = new Volunteer("Ramona", 7, 2);
            AllVolunteers.Add(ramona);
            Volunteer allen = new Volunteer("Allen", 3, 1);
            AllVolunteers.Add(allen);
            Volunteer sam = new Volunteer("Sam", 10, 5);
            AllVolunteers.Add(sam);

            //instantiating 3 managers and adding them to the list:
            Manager julie = new Manager("Julie", 8, 8);
            AllManagers.Add(julie);
            Manager austin = new Manager("Austin", 8, 7);
            AllManagers.Add(austin);
            Manager robin = new Manager("Robin", 8, 9);
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
                {   //manager menu and swtich/case for options:
                    Console.WriteLine("\nManager Menu:");
                    Console.WriteLine("Punch in: 1");
                    Console.WriteLine("Punch out: 2");
                    Console.WriteLine("Host a volunteer training: 3");
                    Console.WriteLine("Host a pet adoption: 4");
                    Console.WriteLine("View a roster: 5");
                    Console.WriteLine("View Adotption Rate: 6");
                    Console.WriteLine("View animals statuses: 7");
                    Console.WriteLine("Exit program: 0");
                    managerChoice = int.Parse(Console.ReadLine());

                    switch (managerChoice)
                    {
                        case 1:
                            //call check in method
                            julie.CheckIn();
                            break;

                        case 2:
                            //call check out method
                            julie.CheckOut();
                            break;

                        case 3:
                            //call trianing method
                            julie.Training();
                            break;

                        case 4:
                            //call adoption method
                            Console.WriteLine("Type \"1\" for dog and \"2\" for cat:");
                            string animalAdopt;
                            string petAdopt;
                            animalAdopt = Console.ReadLine().ToLower();
                            if (animalAdopt == "1")
                            {
                                Console.WriteLine("Which dog is being adopted?  If you are unsure of the dog's names, please hit \"1\" to view the dog roster:");
                                petAdopt = Console.ReadLine();
                                if (petAdopt == "1")
                                {
                                    foreach (string name in juliesVPShelter.DogRoster())
                                    {
                                        Console.WriteLine(name);
                                    }
                                    Console.WriteLine("Which dog is being adopted?");
                                    petAdopt = Console.ReadLine();
                                }
                                julie.Adoption(petAdopt);

                            }
                            else if (animalAdopt == "2")
                            {
                                Console.WriteLine("Which cat is being adopted?  If you are unsure of the cat's names, please hit \"1\" to view the cat roster:");
                                petAdopt = Console.ReadLine();
                                if (petAdopt == "1")
                                {
                                    foreach (string name in juliesVPShelter.CatRoster())
                                    {
                                        Console.WriteLine(name);
                                    }
                                    Console.WriteLine("Which cat is being adopted?");
                                    petAdopt = Console.ReadLine();
                                }
                                julie.Adoption(petAdopt);
                            }
                            break;

                        case 5:
                            //new menu to choose which roster:
                            int rosterChoice;
                            Console.WriteLine("Which roster would you like to view?");
                            Console.WriteLine("Dog roster: 1");
                            Console.WriteLine("Cat roster: 2");
                            Console.WriteLine("Volunteer roster: 3");
                            Console.WriteLine("Manager roster: 4");
                            rosterChoice = int.Parse(Console.ReadLine());
                            if (rosterChoice == 1)
                            {
                                foreach (string name in juliesVPShelter.DogRoster())
                                {
                                    Console.WriteLine(name);
                                }
                            }
                            if (rosterChoice == 2)
                            {
                                foreach (string name in juliesVPShelter.CatRoster())
                                {
                                    Console.WriteLine(name);
                                }
                            }
                            if (rosterChoice == 3)
                            {
                                foreach (string name in juliesVPShelter.VolRoster())
                                {
                                    Console.WriteLine(name);
                                }
                            }
                            if (rosterChoice == 1)
                            {
                                foreach (string name in juliesVPShelter.ManagerRoster())
                                {
                                    Console.WriteLine(name);
                                }
                            }
                            break;

                        case 6:
                            //create method to view adoption rate 
                            julie.ViewScore();
                            break;

                        case 7:
                            //create method to view animal status
                            break;

                        case 0:
                            //0 to quit.
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
                    Console.WriteLine("View volunteer level: 4");
                    Console.WriteLine("View animal statuses: 5");
                    Console.WriteLine("Clean cages: 6");
                    Console.WriteLine("Feed animals: 7");
                    Console.WriteLine("Water animals: 8:");
                    Console.WriteLine("Exit program: 0");

                    volChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            //checkin method
                            sam.CheckIn();
                            break;

                        case 2:
                            //check out method
                            sam.CheckOut();
                            break;

                        case 3:
                            //training method
                            sam.Training();
                            break;

                        case 4:
                            //method to view volunteer experience level:
                            sam.ViewScore();
                            break;

                        case 5:
                            //need to make animal status method
                            break;

                        case 6:
                            //clean cage method (on which pet?)
                            break;

                        case 7:
                            //feed animal method(on which pet?)
                            break;

                        case 8:
                            //water animal method (on which pet?)
                            break;

                        case 0:
                            //0 to quit.
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
