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
        public int VolunteerExperienceLevel { get; set; }
        public int YearsVolunteering { get; set; }

        //constructors:
        public Volunteer(string name, int exlevel, int years)
        {
            this.Name = name;
            this.VolunteerExperienceLevel = exlevel;
            this.YearsVolunteering = years;
        }

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

        public override void ViewScore()
        {
            Console.WriteLine("Your volunteer level is currently {0} out of ten.  " +
                "\nKeep helping animals find homes to inprove the rate!", VolunteerExperienceLevel);
        }

        //volunteer methods:
        public void Feed()
        {
            Console.WriteLine("All pets have been fed, though some may still be hungry.");
        }

        public void Water()
        {
            Console.WriteLine("All pets have been watered, though some may still be thirsty.");
        }

        public void Play(bool bored)
        {
            if (bored == true)
            {
                bored = false;
                Console.WriteLine("The pet had a fun time playing and is no longer bored!");
            }
            else
            {
                Console.WriteLine("The pet wasn't even bored to begin with so is now hyper!");
            }
        }
    }
}
