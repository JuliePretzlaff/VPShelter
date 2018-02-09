using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {
        //properties to create a list for each type of class object
        public List<Dog> AllDogs { get; set; }
        public List<Cat> AllCats { get; set; }
        public List<Volunteer> AllVolunteers { get; set; }
        public List<Manager> AllManagers { get; set; }


        //methods to display the names in each list:
        public List<string> DogRoster()
        {
            List<string> dogRoster = new List<string>();
            foreach (Dog dog in AllDogs)
            {
                dogRoster.Add(dog.Name);
            }
            return dogRoster;
        }

        public List<string> CatRoster()
        {
            List<string> catRoster = new List<string>();
            foreach (Cat cat in AllCats)
            {
                catRoster.Add(cat.Name);
            }
            return catRoster;
        }

        public List<string> VolRoster()
        {
            List<string> volRoster = new List<string>();
            foreach (Volunteer vol in AllVolunteers)
            {
                volRoster.Add(vol.Name);
            }
            return volRoster;
        }

        public List<string> ManagerRoster()
        {
            List<string> managerRoster = new List<string>();
            foreach (Manager manager in AllManagers)
            {
                managerRoster.Add(manager.Name);
            }
            return managerRoster;
        }

    }
}
