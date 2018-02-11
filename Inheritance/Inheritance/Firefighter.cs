using System;
using System.Windows;


//Need to create a WPF project to access Point class
namespace FireTraining
{
    class Firefighter : FirefighterBase
    {
      

        //public void ExtinguishFire()
        public override void ExtinguishFire()
        {
            Console.WriteLine("{0} is putting out the fire..",Name);
            TurnOnHose();
            TrainHoseOnFire();
        }

        protected virtual void TurnOnHose()
        {
            Console.WriteLine("The fire is going out...");
        }

        protected virtual void TrainHoseOnFire()
        {
            Console.WriteLine("Training the hose on the fire....");
        }

    }
}
