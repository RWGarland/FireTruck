using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FireTraining
{
    /*  The fire chief is just another firefighter. 
     *  He can drive a truck. He can put out fires. 
     *  But he can do other stuff too. 
     *  For instance, he can delegate responsibility 
     *  for putting out a
     *  fire to another firefighter.
     */
    class FireChief : Firefighter
    {
        public Firefighter NumberOne { get; set; }

        public void TellFirefighterToExtinguishFire(Firefighter colleague)
        {
            colleague.ExtinguishFire();
        }

        public override void ExtinguishFire()
        {
            TellFirefighterToExtinguishFire(NumberOne);
        }
    }
}
