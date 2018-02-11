using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Cat : VirtualPet
    {
        //fields/properties come from VirtualPet class
        //properties (with invisible fields) specific to this class:
        public string Type { get; set; }
        public string Diet { get; set; }

        //constructors:
        public Cat()
        {
            //default
        }

        //constructor to set type and diet:
        public Cat(string name)
        {
            this.Name = name;
            this.Diet = "cat food";
            this.Type = "cat";
        }

        //constructor to set status bools:
        public Cat(string name, int age, string description) : base(false, false, true)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }
    }
}
