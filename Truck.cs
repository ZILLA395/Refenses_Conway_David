using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refenses_Conway_David
{
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; } 

        // specific to the truck only 
        public double Weight { get; }
        //declaires weight and speed 
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400) 
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
          
        public void Stingify()
            // what is printed to console 
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License plate # of {LicensePlate} ");
        }

        // incresaes speed 5
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
