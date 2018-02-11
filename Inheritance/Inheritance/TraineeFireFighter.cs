using System;
using System.Windows;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace FireTraining
{
    class TraineeFireFighter : Firefighter
    {
        private bool hoseTrainedOnFire;

        protected override void TurnOnHose()
        {
            if (hoseTrainedOnFire)
            {
                base.TurnOnHose();
            }
            else
            {
                Console.WriteLine("There's  water going everywhere!");
            }
        }

        protected override void TrainHoseOnFire()
        {
            hoseTrainedOnFire = true;
            base.TrainHoseOnFire();
        }
    }
}
