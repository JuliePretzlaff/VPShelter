using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class EmployeeClass
    {
        //invisible fields

        //properties:
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }



        //methods:
        public abstract void CheckIn();

        public abstract void CheckOut();

        public abstract void Training();

        public abstract void ViewScore();
       

    }
}
