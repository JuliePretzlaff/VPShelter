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
            //example on how to call a method...might need this.
            //Dog Muffin = new Dog();
            //EmployeeClass pete = new EmployeeClass();
            //pete.Feed(Muffin.IsHungry);

            //instantiate new object of VPS in order to be able to call methods from that class to print lists of anmials
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

            //manager choice variable/menu:
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
                            //choose a pet for adoption and call adoption method.  I wanted to put all of this inside method
                            //in manager class but wasn't able to without instantiating all Dog and Cat object there 
                            //(would instantiating a Dog daisy = new Dog() in two separate classes have it point to the same object of Daisty?
                            //or would it result in two distinct Dog objects, both named daisy?)
                            Console.WriteLine("Type \"1\" for dog and \"2\" for cat:");
                            string animalAdopt;
                            string petAdopt;
                            animalAdopt = Console.ReadLine().ToLower();
                            if (animalAdopt == "1")
                            {
                                Console.WriteLine("Which dog is being adopted?  Please type their name: ");
                                Console.WriteLine(daisy.Name + ": " + daisy.Description);
                                Console.WriteLine(trixie.Name + ": " + trixie.Description);
                                Console.WriteLine(opie.Name + ": " + opie.Description);
                                petAdopt = Console.ReadLine();
                                julie.Adoption(petAdopt);
                            }
                            else if (animalAdopt == "2")
                            {
                                Console.WriteLine("Which cat is being adopted? Please type their name: ");
                                Console.WriteLine(buttons.Name +": " + buttons.Description);
                                Console.WriteLine(bearCat.Name + ": " + bearCat.Description);
                                Console.WriteLine(gucci.Name + ": " + gucci.Description);
                                petAdopt = Console.ReadLine();
;                                julie.Adoption(petAdopt);
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
                            if (rosterChoice == 4)
                            {
                                foreach (string name in juliesVPShelter.ManagerRoster())
                                {
                                    Console.WriteLine(name);
                                }
                            }
                            break;

                        case 6:
                            // method to view adoption rate 
                            julie.ViewScore();
                            break;

                        case 7:
                            Console.WriteLine("\nCurrent Status of Dogs:");
                            //Console.WriteLine(daisy.Name + ": Is hungry?" + daisy.IsHungry + " Is thirsty? " + daisy.IsThirsty + daisy.IsBored);
                            Console.WriteLine("Name    Is Hungry?    Is Thirsty?    Is Bored?");
                            Console.WriteLine("______________________________________________");
                            Console.WriteLine(daisy.Name + "     " + daisy.IsHungry + "         " + daisy.IsThirsty + "           " + daisy.IsBored);
                            Console.WriteLine(trixie.Name + "    " + trixie.IsHungry + "         " + trixie.IsThirsty + "           " + trixie.IsBored);
                            Console.WriteLine(opie.Name + "      " + opie.IsHungry + "         " + opie.IsThirsty + "           " + opie.IsBored);

                            Console.WriteLine("\nCurrent Status of Cats:");
                            Console.WriteLine("Name    Is Hungry?    Is Thirsty?    Is Bored?");
                            Console.WriteLine(buttons.Name + "    " + buttons.IsHungry + "         " + buttons.IsThirsty + "           " + buttons.IsBored);
                            Console.WriteLine(bearCat.Name + "    " + bearCat.IsHungry + "         " + bearCat.IsThirsty + "           " + bearCat.IsBored);
                            Console.WriteLine(gucci.Name + "     " + gucci.IsHungry + "         " + gucci.IsThirsty + "           " + gucci.IsBored);
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

            //volunteer choice variable/menu.  since volunteers interact with pets more frequently than manager,
            //I chose to show the pet status display each time the menu is looped:
            else if (userChoice == 2)
            {
                int volChoice;
                do
                {
                    Console.WriteLine("\nVolunteer Menu (please see all current pet conditions below: ");
                    Console.WriteLine("Sign in: 1");
                    Console.WriteLine("Sign out: 2");
                    Console.WriteLine("Attend a volunteer training: 3");
                    Console.WriteLine("View volunteer level: 4");
                    Console.WriteLine("Play with an animal: 5");
                    Console.WriteLine("Feed animals: 6");
                    Console.WriteLine("Water animals: 7:");
                    Console.WriteLine("Exit program: 0");

                    Console.WriteLine("\nCurrent Status of Dogs:");
                    //Console.WriteLine(daisy.Name + ": Is hungry?" + daisy.IsHungry + " Is thirsty? " + daisy.IsThirsty + daisy.IsBored);
                    Console.WriteLine("Name    Is Hungry?    Is Thirsty?    Is Bored?");
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine(daisy.Name+"     "+daisy.IsHungry +"         "+daisy.IsThirsty+"           "+daisy.IsBored);
                    Console.WriteLine(trixie.Name + "    " + trixie.IsHungry + "         " + trixie.IsThirsty + "           " + trixie.IsBored);
                    Console.WriteLine(opie.Name + "      " + opie.IsHungry + "         " + opie.IsThirsty + "           " + opie.IsBored);

                    Console.WriteLine("\nCurrent Status of Cats:");
                    Console.WriteLine("Name    Is Hungry?    Is Thirsty?    Is Bored?");
                    Console.WriteLine(buttons.Name + "    " + buttons.IsHungry + "         " + buttons.IsThirsty + "           " + buttons.IsBored);
                    Console.WriteLine(bearCat.Name + "    " + bearCat.IsHungry + "         " + bearCat.IsThirsty + "           " + bearCat.IsBored);
                    Console.WriteLine(gucci.Name + "     " + gucci.IsHungry + "         " + gucci.IsThirsty + "           " + gucci.IsBored);

                    volChoice = int.Parse(Console.ReadLine());

                    switch (volChoice)
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
                            //select an animal to play with and method to play with it
                            Console.WriteLine("Would you like to play with a dog or a cat?  Press \"1\" for dog, \"2\" for cat: ");
                            string animalPlay = Console.ReadLine();
                            if (animalPlay == "1")
                            {
                                Console.WriteLine("Which dog would you like to play with: \"1\" for Daisy, \"2\" for Trixie, or \"3\" for Opie?");
                                animalPlay = Console.ReadLine();
                                if (animalPlay == "1")
                                {
                                    sam.Play(daisy.IsBored);
                                }
                                else if (animalPlay == "2")
                                {
                                    sam.Play(trixie.IsBored);
                                }
                                else if (animalPlay == "3")
                                {
                                    sam.Play(opie.IsBored);
                                }
                                else
                                {
                                    Console.WriteLine("Please choose an existing pet!");
                                }
                            }
                            if (animalPlay == "2")
                            {
                                Console.WriteLine("Which cat would you like to play with: \"1\" for Buttons, \"2\" for BearCat, or \"3\" for Gucci?");
                                animalPlay = Console.ReadLine();
                                if (animalPlay == "1")
                                {
                                    sam.Play(buttons.IsBored);
                                }
                                else if (animalPlay == "2")
                                {
                                    sam.Play(bearCat.IsBored);
                                }
                                else if (animalPlay == "3")
                                {
                                    sam.Play(gucci.IsBored);
                                }
                                else
                                {
                                    Console.WriteLine("Please choose an existing pet!");
                                }
                            }

                            break;

                        case 6:
                            //feed animal method
                            sam.Feed();

                            break;

                        case 7:
                            //water animal method
                            sam.Water();
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
