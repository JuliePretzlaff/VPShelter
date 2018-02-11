using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //fields are invisible

        //properties:

        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }
        public bool IsBored { get; set; }
        public bool IsAdopted { get; set; }

        //consturctors:
        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet (string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public VirtualPet(string name, string description, bool hunger, bool thirst, bool bored)
        {
            this.Name = name;
            this.Description = description;
            this.IsHungry = hunger;
            this.IsThirsty = thirst;
            this.IsBored = bored;
        }

        public VirtualPet(bool hunger, bool thirst, bool bored)
        {
            this.IsHungry = hunger;
            this.IsThirsty = thirst;
            this.IsBored = bored;
            this.IsAdopted = false;
        }
    }
}
