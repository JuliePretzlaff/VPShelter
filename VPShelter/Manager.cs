using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : EmployeeClass
    {
        //manager properties:

        int YearsAtJob { get; set; }
        int AdoptionRate { get; set; }


        //constructors:
        public Manager(string name, int rate, int years)
        {
            this.Name = name;
            this.AdoptionRate = rate;
            this.YearsAtJob = years;
        }


        //inherited methods:
        public override void CheckIn()
        {
            DateTime signIn = DateTime.Now;
            Console.WriteLine("You have punched in at " + signIn);
        }

        public override void CheckOut()
        {
            DateTime signOut = DateTime.Now;
            Console.WriteLine("You have punched out at " + signOut);
        }

        public override void Training()
        {
            AdoptionRate++;
            Console.WriteLine("Thank you for helping to better train your volunteers.  Your shelter's adoption rate has increased!");
        }

        public override void ViewScore()
        {
            Console.WriteLine("Your adoption rate is currently {0} out of ten.  " +
                "\nKeep helping animals find homes to inprove the rate!", AdoptionRate);
        }

        //manager methods:
        public void Adoption(string name)
        {
            Console.WriteLine("Congratulations! " + name + " has found a happy, loving home.");
        }

      

    }
}
