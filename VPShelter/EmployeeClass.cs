using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class EmployeeClass
    {
        //invisible fields

        //properties:
        public int EmployeeNumber { get; set; }



        //methods:
        public void Feed(bool hunger)
        {
            if (hunger == true)
            {
                hunger = false;
                Console.WriteLine("The pet is now full!");
            }
            else
            {
                Console.WriteLine("The pet is not hungry!");
            }
        }

        public void Water(bool thirst)
              {
            if (thirst == true)
            {
                thirst = false;
                Console.WriteLine("The pet is no longer thirsty!");
            }
            else
            {
                Console.WriteLine("The pet is not thirsty!");
            }
        }
        //public void Clean();

    }
}
