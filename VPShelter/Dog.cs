using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Dog : VirtualPet
    {

        //fields/properties come from VirtualPet class

        public string Type { get; set; }
        public string Diet { get; set; }

        //constructors:
        public Dog()
        {
            //default
        }

        //constructor to set type and diet:
        public Dog(string name)
        {
            this.Name = name;
            this.Diet = "dog food";
            this.Type = "dog";
        }

        //constructor to set status bools:
        public Dog(string name, int age, string description) : base(false, false, true)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }
    }
}
