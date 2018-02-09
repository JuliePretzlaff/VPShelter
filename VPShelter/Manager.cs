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

        //inherited methods:
        public override void CheckIn()
        {
            DateTime signIn = DateTime.Now;
            Console.WriteLine("You have punched in at " + signIn);
        }

        public override void CheckOut()
        {
            DateTime signOut = DateTime.Now;
            Console.WriteLine("You have punched in at " + signOut);
        }

        public override void Training()
        {
            AdoptionRate++;
            Console.WriteLine("Thank you for helping to better train your volunteers.  Your shelter's adoption rate has increased!");
        }

        //manager methods:
        public void Adoption(VirtualPet pet)
        {
            Console.WriteLine(pet + " has found a happy, loving home.");
        }

    }
}
