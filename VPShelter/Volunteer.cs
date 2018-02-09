using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : EmployeeClass
    {

        //properties:
        public int VolunteerExperienceLevel {get;set;}
        public int YearsVolunteering { get; set; }


        //volunteer inherited methods:
        public override void CheckIn()
        {
            DateTime signIn = DateTime.Now;
            Console.WriteLine("You have signed into the volunteer sign in sheet at " + signIn);
        }

        public override void CheckOut()
        {
            DateTime signOut = DateTime.Now;
            Console.WriteLine("You have signed out of the volunteer sign in sheet at " + signOut);
        }

        public override void Training()
        {
            VolunteerExperienceLevel++;
            Console.WriteLine("Thanks for attending a training session!  Your volunteer level is now " + VolunteerExperienceLevel);
        }

        //volunteer methods:
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
                Console.WriteLine("The pet was not thirsty, but no peed all over it's cage!");
                //make IsClean false;
            }
        }

        public void Clean(bool clean)
        {
            if (clean == true)
            {
                clean = false;
                Console.WriteLine("The pet cage is now clean!");
            }
            else
            {
                Console.WriteLine("The pet cage doesn't need to be cleaned!");
            }
        }
    }
}
