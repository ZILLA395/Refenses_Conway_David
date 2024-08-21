using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refenses_Conway_David
{
    // Like a parent class but not 
    internal interface IAutomobile
    {
        // varibles that are use in all athor tabs 
      public double Speed { get; }

      public int Wheels { get; }

      public string LicensePlate { get; }

        public void Stingify();

    }
}
