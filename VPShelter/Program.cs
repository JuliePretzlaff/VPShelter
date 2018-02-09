using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Muffin = new Dog();
            EmployeeClass pete = new EmployeeClass();

            
            pete.Feed(Muffin.IsHungry);
        }
    }
}
