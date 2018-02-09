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

        public string Type { get; set; }
        public string Diet { get; set; }

        //constructors:
        public Cat()
        {
            //default
        }

        //constructor to set type and diet:
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Diet = "doog food";
            this.Type = "dog";
        }

        //constructor to set status bools:
        public Cat(string name) : base(false, false, true)
        {
            this.Name = name;
        }
    }
}
