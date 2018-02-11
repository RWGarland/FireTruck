using System;
using System.Collections.Generic;
using System.Windows;

namespace FireTraining
{
    abstract class FirefighterBase 
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public abstract void ExtinguishFire();

        public void Drive(Firetruck truckToDrive, String coordinates)
        {
            if (truckToDrive.Driver != this)
            {
                return;
            }
            truckToDrive.Drive(coordinates);
        }

    }
}
