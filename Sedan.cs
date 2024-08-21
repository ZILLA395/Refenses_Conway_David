using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refenses_Conway_David
{
    internal class Sedan : IAutomobile
    {
       public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed) 
        {
            Wheels = 4;
            speed = speed;
            LicensePlate = "489-PCE";
        }
        // what is printed to console 
        public void Stingify()
        {
           Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }
        // increases speed by 5
        public void IncreaseSpeed() 
        {
            Speed += 5;
        }

        // decreases speed by 5 
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
